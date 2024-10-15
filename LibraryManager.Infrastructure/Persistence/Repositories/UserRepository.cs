using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryManagerDbContext _context;
        public UserRepository(LibraryManagerDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Users.AnyAsync(p => p.Id == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users
                .Where(p => !p.IsDeleted).ToListAsync();
        }

        public async Task<User> GetByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _context.Users.SingleOrDefaultAsync(p => p.Email == email && p.Password == passwordHash);
        }

        public async Task<User?> GetById(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<User?> GetDetailsById(int id)
        {
            var users = await _context.Users
                .SingleOrDefaultAsync(p => p.Id == id);

            return users;
        }

        public async Task Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
