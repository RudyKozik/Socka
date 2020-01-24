using System;
using System.Collections.Generic;
using System.Text;

namespace SockaBackend.Domain
{
    public class Comment : Entity<Guid>
    {
        public string Content { get; private set; }
        public string Author { get; private set; }
        public Guid IdFeed { get; private set; }

        public Comment()
        {
            Id = Guid.NewGuid();
        }

        public Comment(string content, string author, Guid idFeed) : this()
        {
            Content = content;
            Author = author;
            IdFeed = idFeed;
        }
    }
}
