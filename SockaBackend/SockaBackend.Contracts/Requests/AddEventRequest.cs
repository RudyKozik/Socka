using System;

namespace SockaBackend.Contracts.Requests
{
    public class AddEventRequest
    {
        public string Name { get; set; }
        public string Organizer { get; set; }
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Url { get; set; }
    }
}
