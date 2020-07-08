using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using Posts.Comments.Likes.Infrastructure.Entities;

namespace Posts.Comments.Likes.Infrastructure.Services
{
    public interface ILikeService
    {
        IMongoQueryable<Like> GetLikes(string commentId);

        Task<Like> GetLike(string id);

        Task<Like> Unlike(int userId, string commentId);

        Task<Like> Like(Like like);
    }
}