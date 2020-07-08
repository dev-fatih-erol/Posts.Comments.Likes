using MediatR;
using Posts.Comments.Likes.Application.Dtos;

namespace Posts.Comments.Likes.Application.Queries
{
    public class GetLikeQuery : IRequest<LikeDto>
    {
        public string Id { get; }

        public GetLikeQuery(string id)
        {
            Id = id;
        }
    }
}