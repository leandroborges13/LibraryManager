using LibraryManager.Application.Models;
using LibraryManager.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.LoanQuery
{
    public class GetAllLoanHandler : IRequestHandler<GetAllLoanQuery, ResultViewModel<List<LoanItemViewModel>>>
    {
        private readonly ILoanRepository _repository;
        public GetAllLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<LoanItemViewModel>>> Handle(GetAllLoanQuery request, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetAll();

            var model = loan.Select(LoanItemViewModel.FromEntity).ToList();

            return ResultViewModel<List<LoanItemViewModel>>.Success(model);
        }
    }
}
