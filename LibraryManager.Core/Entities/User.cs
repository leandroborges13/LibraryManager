namespace LibraryManager.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email) : base()
        {
            Name = name;
            Email = email;
            Active = true;

            //ListBookLoan = [];
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        //public List<Loan> ListBookLoan { get; private set; }


        public void Update(string name, string email)
        {
            Name = name;
            Email = email;

        }
    }
}
