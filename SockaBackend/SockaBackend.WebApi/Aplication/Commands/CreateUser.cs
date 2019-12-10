using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class CreateUserRequest : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public CreateUserRequest(string name, string surname, string mail, string password)
        {
            Name = name;
            Surname = surname;
            Mail = mail;
            Password = password;
        }
    }
}
