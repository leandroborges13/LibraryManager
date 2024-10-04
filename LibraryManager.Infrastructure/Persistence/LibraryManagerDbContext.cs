using LibraryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure.Persistence
{
    public class LibraryManagerDbContext : DbContext
    {
        public LibraryManagerDbContext(DbContextOptions<LibraryManagerDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(e => {

                e.HasKey(s => s.Id);

            });

            builder
              .Entity<User>(e =>
              {
                  e.HasKey(u => u.Id);

                  e.HasMany(u => u.ListBookLoan)
                      .WithOne(us => us.User)
                      .HasForeignKey(us => us.IdUser)
                      .OnDelete(DeleteBehavior.Restrict);
              });

            builder.Entity<Loan>(e => {

                e.HasKey(s => s.Id);

                e.HasOne(p => p.User)
                    .WithMany(c => c.ListBookLoan)
                    .HasForeignKey(p => p.IdUser)
                    .OnDelete(DeleteBehavior.Restrict);

            });
        }
    }
}
