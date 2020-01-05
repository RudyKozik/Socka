using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SockaBackend.Contracts.Requests;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;

namespace SockaBackend.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly Database database;
        private readonly ILogger<UserController> logger;
        private readonly IMediator mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator, Database database)
        {
            this.database = database;
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get(string id) 
        {
            var get = database.Users.SingleOrDefault(x => x.Id == id);

            if(get == null)
            {
                return null;
            }

            return Ok(get);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRequest request, CancellationToken cancellation)
        {
            var getId = Get(request.Id);

            if(getId == null)
            {
                await mediator.Send(new CreateUserCommand(request.Id, request.Name, request.Surname, request.Mail), cancellation);
            }
            return Ok();
        }
    }
}