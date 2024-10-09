using FluentValidation;
using LibraryManager.Application.Commands.UserCommands.InsertUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Validators.UserValidators
{
    public class InserUserValidator : AbstractValidator<InsertUserCommand>
    {
        public InserUserValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("Não pode ser nulo.")
               .MaximumLength(50).WithMessage("Tamanho máximo 50 caracteres.");

            RuleFor(p => p.Email)
                .EmailAddress().WithMessage("E-mail inválido")
                .NotEmpty().WithMessage("Não pode ser nulo.");
        }
    }
}
