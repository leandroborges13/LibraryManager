using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Models
{
    public class LoanItemViewModel
    {
        public LoanItemViewModel(int id, string book, string user, DateTime startedAt, int daysLoan, DateTime? finishedAt)
        {
            Id = id;
            Book = book;
            User = user;
            StartedAt = startedAt;
            DaysLoan = daysLoan;
            FinishedAt = finishedAt;
        }

        public int Id { get; set; }
        public string Book { get; set; }
        public string User { get; set; }
        public DateTime StartedAt { get; set; }
        public int DaysLoan { get; set; }
        public DateTime? FinishedAt { get; set; }

        public static LoanItemViewModel FromEntity(Loan loan)
         => new(loan.Id, loan.Book?.Titulo ?? "", loan.User?.Name ?? "", loan.StartedAt, loan.DaysLoan, loan.FinishedAt);
    }
}
