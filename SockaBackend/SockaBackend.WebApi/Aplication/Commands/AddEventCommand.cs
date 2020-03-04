using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Aplication.Commands
{
    public class AddEventCommand : IRequest
    {
        public string Name { get; }
        public string Organizer { get; }
        public string Location { get; }
        public string StartDate { get; }
        public string EndDate { get; }
        public string Url { get; }

        public AddEventCommand(string name, string organizer, string location, string startDate, string endDate, string url)
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
