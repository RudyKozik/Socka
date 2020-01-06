using System;
using System.Collections.Generic;
using System.Text;

namespace SockaBackend.Domain
{
    class Feed
    {
        public string Status { get; private set; }
        public int Likes { get; private set; }
        public string Author { get; private set; }
        public string Data { get; private set; }
    }
}
