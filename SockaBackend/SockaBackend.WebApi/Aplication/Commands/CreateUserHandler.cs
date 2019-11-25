using MediatR;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace SockaBackend.WebApi.Aplication.Queries
{
    public class CreateUserHandler : AsyncRequestHandler<CreateUserRequest>
    {
        private readonly Database database;

        public CreateUserHandler(Database database)
        {
            this.database = database;
        }


        protected override async Task Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            database.Users.Add(new Domain.User(request.Password, request.Name));
            
            await database.SaveChangesAsync(cancellationToken);      
        }
    }
}
