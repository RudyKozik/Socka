using SockaBackend.Domain.Common;
using System;

namespace SockaBackend.Domain
{
    public class User : Entity<Guid>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Mail { get; private set; }

        public User()
        {
            Id = Guid.NewGuid();  
        }

        public User(string name, string surname, string mail) : this()
        {
            if (string.IsNullOrEmpty(mail))
            {
                throw new ArgumentException();
            }
            Name = name;
            Surname = surname;
            Mail = mail;
        }
    }
}
