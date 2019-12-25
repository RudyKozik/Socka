using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SockaBackend.Contracts.Requests;
using SockaBackend.WebApi.Aplication.Commands;

namespace SockaBackend.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> logger;
        private readonly IMediator mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }       

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new CreateUserCommand(request.Name, request.Surname, request.Mail), cancellation);
            return Ok();
        }
    }
}