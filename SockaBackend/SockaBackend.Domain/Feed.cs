
using System;

namespace SockaBackend.Domain
{
    public class Feed : Entity<Guid>
    {
        public string Status { get; private set; }
        public int Likes { get; set; }
        public string Author { get; private set; }
        public string Date { get; private set; }

        public Feed()
        {
            Id = Guid.NewGuid();
        }

        public Feed(string status, int likes, string author, string date) : this()
        {
            Status = status;
            Likes = likes;
            Author = author;
            Date = date;
        }

        public Feed(int likes)
        {
            Likes = likes;
        }
    }
}
