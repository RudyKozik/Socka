using System;
using System.Collections.Generic;
using System.Text;

namespace SockaBackend.Domain
{
   public class Event : Entity<Guid>
    {
        public string Name { get; private set; }
        public string Organizer { get; private set; }
        public string Location { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public string Url { get; private set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }

        public Event(string name, string organizer, string location, string startDate, string endDate, string url) : this()
        {
            Name = name;
            Organizer = organizer;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            Url = url;
        }
    }
}
