using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SockaBackend.WebApi.Aplication.Commands;
using SockaBackend.WebApi.Aplication.RequestModels;

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
        public async Task<IActionResult> CreateUser(CreateUserRequestModel request, CancellationToken cancellation)
        {
            await mediator.Send(new CreateUserRequest(request.Name, request.Surname, request.Mail, request.Password), cancellation);
            return Ok();
        }
    }
}