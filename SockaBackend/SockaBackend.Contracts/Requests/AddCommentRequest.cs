using System;

namespace SockaBackend.Contracts.Requests
{
    public class AddCommentRequest
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public Guid IdFeed { get; set; }
    }
}
