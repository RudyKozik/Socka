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
        private readonly IMediator mediator;

        public UserController(IMediator mediator, Database database)
        {
            this.database = database;
            this.mediator = mediator;
        }

        [HttpGet(ApiRoutes.Users.Get)]
        public IActionResult Get(string id) 
        {
            var get = database.Users.SingleOrDefault(x => x.Id == id);

            if(get == null)
            {
                return null;
            }

            return Ok(get);
        }

        [HttpPost(ApiRoutes.Users.Create)]
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