using FluentValidation;
using FluentValidation.AspNetCore;
using LibraryManager.Application.Commands.LoanCommands.InsertLoan;
using LibraryManager.Application.Commands.UserCommands.InsertUser;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LibraryManager.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddHandlers()
                .AddValidation()
                .AddAuthorizeJwt(configuration);

            return services;
        }

        private static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<InsertLoanCommand>());

            return services;
        }

        private static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<InsertUserCommand>();
            return services;
        }

        private static IServiceCollection AddAuthorizeJwt(this IServiceCollection services, IConfiguration configuration)
        {
            services
             .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,

                     ValidIssuer = configuration["Jwt:Issuer"],
                     ValidAudience = configuration["Jwt:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey
                   (Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                 };
             });

            return services;
        }
    }
}
