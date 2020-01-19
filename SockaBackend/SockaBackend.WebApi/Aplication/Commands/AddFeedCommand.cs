using MediatR;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddFeedCommand : IRequest
    {
        public string Status { get; }
        public int Likes { get; }
        public string Author { get; }
        public string Date { get; }

        public AddFeedCommand(string status, int likes, string author, string date)
        {
            Status = status;
            Likes = likes;
            Author = author;
            Date = date;
        }
    }
}
