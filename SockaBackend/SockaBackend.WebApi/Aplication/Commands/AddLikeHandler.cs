using MediatR;
using SockaBackend.Domain;
using SockaBackend.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddLikeHandler : AsyncRequestHandler<AddLikeCommand>
    {
        private readonly Database database;

        public AddLikeHandler(Database database)
        {
            this.database = database;
        }

        protected override async Task Handle(AddLikeCommand request, CancellationToken cancellationToken)
        {
            var feed = database.Feeds.Find(request.Id);

            feed.Likes = request.Like;

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
