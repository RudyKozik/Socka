using System;

namespace SockaBackend.Domain
{
    public class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Mail { get; private set; }
        public string Password { get; private set; }
        




        public User()
        {
            Id = Guid.NewGuid().ToString();  
        }

        public User(string name, string surname, string mail, string password) : this()
        {
            Name = name;
            Surname = surname;
            Mail = mail;
            Password = password;
        }
    }
}
