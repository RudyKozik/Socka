using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddLikeCommand : IRequest
    {
        public Guid Id { get; }
        public int Like { get; }

        public AddLikeCommand(Guid id, int like)
        {
            Id = id;
            Like = like;
        }
    }
}
