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
    public class AddCommentHandler : AsyncRequestHandler<AddCommentCommand>
    {
        private readonly Database database;

        public AddCommentHandler(Database database)
        {
            this.database = database;
        }
        protected override async Task Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            database.Comments.Add(new Comment(request.Content, request.Author, request.IdFeed));

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
