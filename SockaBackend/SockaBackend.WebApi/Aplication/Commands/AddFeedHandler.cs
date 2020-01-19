using MediatR;
using SockaBackend.Domain;
using SockaBackend.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddFeedHandler : AsyncRequestHandler<AddFeedCommand>
    {
        private readonly Database database;

        public AddFeedHandler(Database database)
        {
            this.database = database;
        }

        protected override async Task Handle(AddFeedCommand request, CancellationToken cancellationToken)
        {
            database.Feeds.Add(new Feed(request.Status, request.Likes, request.Author, request.Date));

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
