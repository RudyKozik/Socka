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
        public string Password { get; set; }

        public CreateUserRequest(string name,string password)
        {
            Name = name;
            Password = password;
        }
    }
}
