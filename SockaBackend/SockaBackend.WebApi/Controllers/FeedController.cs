using MediatR;
using Microsoft.AspNetCore.Mvc;
using SockaBackend.Contracts.Requests;
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
        private readonly IMediator mediator;
        public FeedController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpPost]
        
        public async Task<IActionResult> AddFeed(AddFeedRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddFeedCommand(request.Status, request.Likes, request.Author, request.Date), cancellation);
            return Ok();
        }
    }
}
