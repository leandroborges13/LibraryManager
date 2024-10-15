namespace LibraryManager.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, string password, string role) : base()
        {
            Name = name;
            Email = email;
            Active = true;
            Role = role;
            Password = password;

            
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }


        public void Update(string name, string email)
        {
            Name = name;
            Email = email;

        }
    }
}
