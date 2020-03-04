using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SockaBackend.Contracts.Requests;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;

namespace SockaBackend.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class EventController : Controller
    {
        private readonly IMediator mediator;

        private readonly Database database;

        public EventController(IMediator mediator, Database database)
        {
            this.mediator = mediator;
            this.database = database;
        }

        [HttpPost(ApiRoutes.Events.Add)]
        public async Task<IActionResult> AddEvent(AddEventRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddEventCommand(request.Name, request.Organizer, request.Location, request.StartDate, request.EndDate, request.Url), cancellation);

            return Ok();
        }

        [HttpPost(ApiRoutes.Teams.Add)]
        public async Task<IActionResult> AddTeam(AddTeamRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddTeamCommand(request.Name), cancellation);

            return Ok();
        }

        [HttpGet(ApiRoutes.Teams.Get)]
        public IActionResult GetAll()
        {
            var teams = database.Teams;
            return Ok(teams);
        }
    }
}
