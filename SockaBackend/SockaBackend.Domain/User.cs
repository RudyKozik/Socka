using System;

namespace SockaBackend.Domain
{
    public class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Mail { get; private set; }

        public User()
        {

        }

        public User(string id, string name, string surname, string mail) : this()
        {
            Id = id;
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
