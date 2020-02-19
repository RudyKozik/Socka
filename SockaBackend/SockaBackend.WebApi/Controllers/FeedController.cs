using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SockaBackend.Contracts.Requests;
using SockaBackend.Infrastructure;
using SockaBackend.WebApi.Aplication.Commands;
using System;
using System.Linq;
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

        [HttpDelete(ApiRoutes.Feeds.Delete)]
        public async Task<IActionResult> DeleteFeed(DeleteFeedRequest request , CancellationToken cancellation)
        {
            await mediator.Send(new DeleteFeedCommand(request.Id), cancellation);
            return NoContent();
        }

        [HttpGet(ApiRoutes.Feeds.GetComments)]
        public IActionResult GetComments()
        {
            var comments = database.Comments;
            return Ok(comments);
        }

        [HttpPost(ApiRoutes.Feeds.Create)]
        public async Task<IActionResult> AddFeed(AddFeedRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddFeedCommand(request.Status, request.Likes, request.Author, request.Date), cancellation);
            return Ok();
        }

        [HttpPost(ApiRoutes.Feeds.AddLike)]
        public async Task<IActionResult> AddLike(AddLikeRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddLikeCommand(request.Id, request.Like), cancellation);
            return Ok();
        }

        [HttpPost(ApiRoutes.Feeds.AddComment)]
        public async Task<IActionResult> AddComment(AddCommentRequest request, CancellationToken cancellation)
        {
            await mediator.Send(new AddCommentCommand(request.Content, request.Author, request.IdFeed), cancellation);
            return Ok();
        }
    }
}
