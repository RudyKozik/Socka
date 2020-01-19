using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Controllers
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Feeds
        {
            public const string GetAll = Base + "/getAll";

            public const string Create = Base + "/create";

            public const string AddLike = Base + "/addLike";

            public const string UpdateLike = Base + "/updateLike";
        }

        public static class Users
        {
            public const string Get = Base + "/users/{id}";

            public const string Create = Base + "/users";
        }
    }
}
