using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.UnitTests.Core.Entities
{
    public class LoanTests
    {
        [Fact]
        public void TestIfLoanValidWorks()
        {
            var book = new Loan(1, 1, DateTime.Now, 10);

           Assert.True(book.DaysLoan > 0);

        }
    }
}
