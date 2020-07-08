using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Posts.Comments.Likes.Application.Commands;

namespace Posts.Comments.Likes.Api.Controllers
{
    public class LikeController : Controller
    {
        private readonly IMediator _mediator;

        public LikeController(IMediator mediator)
        {
            _mediator = mediator;
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