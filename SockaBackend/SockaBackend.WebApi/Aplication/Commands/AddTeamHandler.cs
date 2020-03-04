using MediatR;
using SockaBackend.Domain;
using SockaBackend.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddTeamHandler : AsyncRequestHandler<AddTeamCommand>
    {
        private readonly Database database;

        public AddTeamHandler(Database database)
        {
            this.database = database;
        }
        protected override async Task Handle(AddTeamCommand request, CancellationToken cancellationToken)
        {
            database.Teams.Add(new Team( request.Name));

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
