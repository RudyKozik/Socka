using MediatR;
using SockaBackend.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class DeleteFeedHandler : AsyncRequestHandler<DeleteFeedCommand>
    {
        private readonly Database database;

        public DeleteFeedHandler(Database database)
        {
            this.database = database;
        }

        protected override async Task Handle(DeleteFeedCommand request, CancellationToken cancellationToken)
        {
            var feed = database.Feeds.Find(request.Id);

            database.Feeds.Remove(feed);

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
