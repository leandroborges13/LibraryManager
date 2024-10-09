using LibraryManager.Application.Models;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.LoanCommands.InsertLoan
{
    public class InsertLoanHandler : IRequestHandler<InsertLoanCommand, ResultViewModel>
    {
        private readonly ILoanRepository _repository;
        public InsertLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(InsertLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan(request.IdUser, request.IdBook, request.StartedAt, request.DaysLoan);

            await _repository.Add(loan);

            return ResultViewModel.Success();
        }
    }
}
