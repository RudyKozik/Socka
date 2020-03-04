using System;
using System.Collections.Generic;
using System.Text;

namespace SockaBackend.Domain
{
    public class Team : Entity<Guid>
    {
        public string Name { get; private set; }

        public Team()
        {
            Id = Guid.NewGuid();
        }

        public Team(string name) : this()
        {
            Name = name;
        }
    }
}
