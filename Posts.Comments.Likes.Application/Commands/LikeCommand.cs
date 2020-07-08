using MediatR;
using Posts.Comments.Likes.Application.Dtos;

namespace Posts.Comments.Likes.Application.Commands
{
    public class LikeCommand : IRequest<LikeDto>
    {
        public UserDto User { get; }

        public string CommentId { get; }

        public LikeCommand(UserDto user, string commentId)
        {
            User = user;

            CommentId = commentId;
        }
    }
}