using LibraryManager.Application.Models;
using LibraryManager.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Queries.LoanQuery
{
    public class GetAllLoanQuery : IRequest<ResultViewModel<List<LoanItemViewModel>>>
    {
    }
}
