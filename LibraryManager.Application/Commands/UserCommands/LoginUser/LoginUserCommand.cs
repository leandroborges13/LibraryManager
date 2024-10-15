using LibraryManager.Application.Models;
using MediatR;

namespace LibraryManager.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<ResultViewModel<LoginUserViewModel>>
    {
        public LoginUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
