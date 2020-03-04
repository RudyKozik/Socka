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
    public class AddEventHandler : AsyncRequestHandler<AddEventCommand>
    {
        private readonly Database database;

        public AddEventHandler(Database database)
        {
            this.database = database;
        }

        protected override async Task Handle(AddEventCommand request, CancellationToken cancellationToken)
        {
            database.Tournaments.Add(new Event(request.Name, request.Organizer, request.Location, request.StartDate, request.EndDate, request.Url));

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
