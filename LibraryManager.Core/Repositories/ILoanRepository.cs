using LibraryManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<List<Loan>> GetAll();
        Task<Loan?> GetDetailsById(int id);
        Task<Loan?> GetById(int id);
        Task<int> Add(Loan loan);
        Task Update(Loan loan);
        Task<bool> Exists(int id);
    }
}
