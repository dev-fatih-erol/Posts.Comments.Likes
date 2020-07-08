using MediatR;

namespace Posts.Comments.Likes.Application.Commands
{
    public class UnlikeCommand : IRequest<Unit>
    {
        public int UserId { get; }

        public string CommentId { get; }

        public UnlikeCommand(int userId, string commentId)
        {
            UserId = userId;

            CommentId = commentId;
        }
    }
}