namespace SockaBackend.Contracts.Requests
{
    public class CreateUserRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
    }
}
