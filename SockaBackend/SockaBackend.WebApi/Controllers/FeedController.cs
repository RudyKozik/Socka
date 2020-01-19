using MediatR;
using Microsoft.AspNetCore.Mvc;
using SockaBackend.Contracts.Requests;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace SockaBackend.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("[controller]")]
    public class FeedController : Controller
    {
        private readonly Database database;
        private readonly IMediator mediator;
        public FeedController(IMediator mediator, Database database)
        {
            this.database = database;
            this.mediator = mediator;
        }

        [HttpGet(ApiRoutes.Feeds.GetAll)]
        public IActionResult GetAll()
        {
            var feeds = database.Feeds;
            return Ok(feeds);
        }

        [HttpPost(ApiRoutes.Feeds.Create)]
        public async Task<IActionResult> AddFeed(AddFeedRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddFeedCommand(request.Status, request.Likes, request.Author, request.Date), cancellation);
            return Ok();
        }
    }
}
