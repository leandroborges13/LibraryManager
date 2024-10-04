using LibraryManager.Core.Entities;

namespace LibraryManager.Application.Models
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email, List<Loan> listLoan)
        {
            FullName = fullName;
            Email = email;
            ListLoan = listLoan;

        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public List<Loan> ListLoan { get; private set; }

        public static UserViewModel FromEntity(User user) => new(user.Name, user.Email, user.ListBookLoan);
        
    }
}
