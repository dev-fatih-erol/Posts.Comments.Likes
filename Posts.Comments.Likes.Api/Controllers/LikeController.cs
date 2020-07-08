using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Posts.Comments.Likes.Application.Commands;
using Posts.Comments.Likes.Application.Queries;

namespace Posts.Comments.Likes.Api.Controllers
{
    public class LikeController : Controller
    {
        private readonly IMediator _mediator;

        public LikeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Comment/{commentId:length(24)}/Like")]
        public async Task<IActionResult> GetLikes([FromRoute]string commentId, [FromQuery]int pageIndex = 1)
        {
            return Ok(await _mediator.Send(new GetLikesQuery(commentId, pageIndex)));
        }

        [HttpGet]
        [Route("Like/{id:length(24)}")]
        public async Task<IActionResult> GetLike([FromRoute]string id)
        {
            return Ok(await _mediator.Send(new GetLikeQuery(id)));
        }

        [HttpDelete]
        [Route("Like/{commentId:length(24)}")]
        public async Task<IActionResult> Unlike([FromRoute]string commentId)
        {
            int userId = 3;
            await _mediator.Send(new UnlikeCommand(userId, commentId));

            return NoContent();
        }

        [HttpPost]
        [Route("Like")]
        public async Task<IActionResult> Like([FromBody]LikeCommand command)
        {
            var like = await _mediator.Send(command);

            return Created($"Like/{like.Id}", like);
        }
    }
}