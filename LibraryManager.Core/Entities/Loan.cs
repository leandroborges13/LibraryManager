using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(int idUser, int idBook, DateTime startedAt, int daysLoan) : base()
        {
            IdUser = idUser;
            IdBook = idBook;
            StartedAt = startedAt;
            DaysLoan = daysLoan;

            FinishedAt = null;
        }

        public int IdUser { get; private set; }
        public int IdBook { get; private set; }
        public DateTime StartedAt { get; private set; }
        public int DaysLoan { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public User User { get; private set; }
        public Book Book { get; private set; }

    }
}
