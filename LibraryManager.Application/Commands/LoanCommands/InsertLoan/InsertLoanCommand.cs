using LibraryManager.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Commands.LoanCommands.InsertLoan
{
    public class InsertLoanCommand : IRequest<ResultViewModel>
    {
        public int IdUser { get;  set; }
        public int IdBook { get;  set; }
        public DateTime StartedAt { get;  set; }
        public int DaysLoan { get;  set; }
    }
}
