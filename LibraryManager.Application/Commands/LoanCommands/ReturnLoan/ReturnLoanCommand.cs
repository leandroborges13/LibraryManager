using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.LoanCommands.ReturnLoan
{
    public class ReturnLoanCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public DateTime FinishedAt { get; set; }
    }
}
