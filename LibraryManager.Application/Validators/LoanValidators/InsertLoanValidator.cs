using FluentValidation;
using LibraryManager.Application.Commands.BookCommands.InsertBook;
using LibraryManager.Application.Commands.LoanCommands.InsertLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Validators.LoanValidators
{
    public class InsertLoanValidator : AbstractValidator<InsertLoanCommand>
    {
        public InsertLoanValidator() {
            RuleFor(p => p.DaysLoan)
                .GreaterThan(0).WithMessage("Dias de empréstimo tem que ser maior que zero.");
        }
    }
}
