using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class DeleteFeedCommand : IRequest
    {
        public Guid Id { get; }

        public DeleteFeedCommand(Guid id)
        {
            Id = id;
        }
    }
}
