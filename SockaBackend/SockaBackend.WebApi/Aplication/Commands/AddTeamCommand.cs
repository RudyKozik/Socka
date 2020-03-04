using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddTeamCommand : IRequest
    {
        public string Name { get; set; }

        public AddTeamCommand(string name)
        {
            Name = name;
        }
    }
}
