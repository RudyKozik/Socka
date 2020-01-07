namespace SockaBackend.Contracts.Requests
{
    public class AddFeedRequest
    {
        public string Status { get; set; }
        public int Likes { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
    }
}
