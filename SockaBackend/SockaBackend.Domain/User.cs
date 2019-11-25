using System;

namespace SockaBackend.Domain
{
    public class User
    {
        public string Id { get; private set; }
        public string Password { get; private set; }
        public string UserName { get; private set; }



        public User()
        {
            Id = Guid.NewGuid().ToString();  
        }

        public User(string password, string userName) : this()
        {
            Password = password;
            UserName = userName;
        }
    }
}
