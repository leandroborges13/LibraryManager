using FluentValidation;
using LibraryManager.Application.Commands.BookCommands.InsertBook;
using LibraryManager.Application.Commands.BookCommands.UpdateBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Validators.BookValidators
{
    public class UpdateBookValidators : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookValidators() {
            RuleFor(p => p.Author)
             .NotEmpty().WithMessage("Não pode ser nulo.")
             .MaximumLength(100).WithMessage("Tamanho máximo 100 caracteres.");

            RuleFor(p => p.Titulo)
              .NotEmpty().WithMessage("Não pode ser nulo.")
              .MaximumLength(100).WithMessage("Tamanho máximo 100 caracteres.");

            RuleFor(p => p.ISBN)
              .NotEmpty().WithMessage("Não pode ser nulo.")
              .MaximumLength(100).WithMessage("Tamanho máximo 100 caracteres.");

            RuleFor(p => p.PublisherDate)
             .NotEmpty().WithMessage("Não pode ser nulo.");
        }
    }
}
