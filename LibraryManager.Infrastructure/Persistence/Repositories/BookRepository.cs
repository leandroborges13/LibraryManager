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
    public class BookRepository : IBookRepository
    {
        private readonly LibraryManagerDbContext _context;
        public BookRepository(LibraryManagerDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return book.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Books.AnyAsync(p => p.Id == id);
        }

        public async Task<List<Book>> GetAll()
        {
            return await _context.Books
                .Where(p => !p.IsDeleted).ToListAsync();
        }

        public async Task<Book?> GetById(int id)
        {
            return await _context.Books.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task Update(Book project)
        {
            _context.Books.Update(project);
            await _context.SaveChangesAsync();
        }
    }
}
