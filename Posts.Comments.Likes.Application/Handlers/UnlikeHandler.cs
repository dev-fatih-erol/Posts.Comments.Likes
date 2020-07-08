using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Posts.Comments.Likes.Application.Commands;
using Posts.Comments.Likes.Infrastructure.Services;

namespace Posts.Comments.Likes.Application.Handlers
{
    public class UnlikeHandler : IRequestHandler<UnlikeCommand, Unit>
    {
        private readonly ILikeService _likeService;

        public UnlikeHandler(ILikeService likeService)
        {
            _likeService = likeService;
        }

        public async Task<Unit> Handle(UnlikeCommand request, CancellationToken cancellationToken)
        {
            await _likeService.Unlike(request.UserId, request.CommentId);

            return Unit.Value;
        }
    }
}