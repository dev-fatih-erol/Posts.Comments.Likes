using MediatR;
using Posts.Comments.Likes.Application.Dtos;

namespace Posts.Comments.Likes.Application.Queries
{
    public class GetLikesQuery : IRequest<PaginatedListDto<LikeDto>>
    {
        public string CommentId { get; }

        public int PageIndex { get; }

        public GetLikesQuery(string commentId, int pageIndex)
        {
            CommentId = commentId;

            PageIndex = pageIndex < 1 ? 1 : pageIndex;
        }
    }
}