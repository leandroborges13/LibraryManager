using LibraryManager.Application.Models;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.LoanCommands.ReturnLoan
{
    public class ReturnLoanHandler : IRequestHandler<ReturnLoanCommand, ResultViewModel>
    {
        private readonly ILoanRepository _repository;
        public ReturnLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(ReturnLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetById(request.Id);

            if (loan is null)
            {
                return ResultViewModel.Error("Empréstimo não existe.");
            }

            loan.Return(request.FinishedAt);

            await _repository.Update(loan);

            return ResultViewModel.Success();
        }
    }
}
