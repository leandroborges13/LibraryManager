using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryManagerDbContext _context;
        public LoanRepository(LibraryManagerDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Loan loan)
        {
            await _context.Loans.AddAsync(loan);
            await _context.SaveChangesAsync();

            return loan.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Loans.AnyAsync(p => p.Id == id);
        }

        public async Task<List<Loan>> GetAll()
        {
            return await _context.Loans
               .Where(p => !p.IsDeleted).ToListAsync();
        }

        public async Task<Loan?> GetById(int id)
        {
            return await _context.Loans.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Loan?> GetDetailsById(int id)
        {
            return await _context.Loans
                .Include(p => p.User)
                .Include(p => p.Book)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task Update(Loan project)
        {
            _context.Loans.Update(project);
            await _context.SaveChangesAsync();
        }
    }
}
