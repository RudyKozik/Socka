using MediatR;
using System;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddCommentCommand : IRequest
    {
        public string Content { get; }
        public string Author { get; }
        public Guid IdFeed { get; }

        public AddCommentCommand(string content, string author, Guid idFeed)
        {
            Content = content;
            Author = author;
            IdFeed = idFeed;
        }
    }
}
