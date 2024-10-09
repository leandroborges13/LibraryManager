using FluentValidation;
using LibraryManager.Application.Commands.UserCommands.InsertUser;
using LibraryManager.Application.Commands.UserCommands.UpdateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Validators.UserValidators
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserValidator() {
            RuleFor(p => p.Name)
              .NotEmpty().WithMessage("Não pode ser nulo.")
              .MaximumLength(50).WithMessage("Tamanho máximo 50 caracteres.");

            RuleFor(p => p.Email)
                .EmailAddress().WithMessage("E-mail inválido")
                .NotEmpty().WithMessage("Não pode ser nulo.");
        }
    }
}
