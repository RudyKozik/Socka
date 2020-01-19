using MediatR;
using SockaBackend.Domain;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace SockaBackend.WebApi.Aplication.Queries
{
    public class CreateUserHandler : AsyncRequestHandler<CreateUserCommand>
    {
        private readonly Database database;

        public CreateUserHandler(Database database)
        {
            this.database = database;
        }


        protected override async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if(database.Users.Any(u => u.Mail == request.Mail))
            {
                throw new ArgumentException();
            }

            database.Users.Add(new User(request.Id, request.Name, request.Surname, request.Mail));
            
            await database.SaveChangesAsync(cancellationToken);      
        }
    }
}
