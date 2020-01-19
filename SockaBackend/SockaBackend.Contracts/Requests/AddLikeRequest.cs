using System;

namespace SockaBackend.Contracts.Requests
{
    public class AddLikeRequest
    {
        public Guid Id { get; set; }
        public int Like { get; set; }
    }
}
