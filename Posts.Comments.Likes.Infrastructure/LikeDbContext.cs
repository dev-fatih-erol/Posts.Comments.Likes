using MongoDB.Driver;
using Posts.Comments.Likes.Infrastructure.Configurations;
using Posts.Comments.Likes.Infrastructure.Entities;

namespace Posts.Comments.Likes.Infrastructure
{
    public class LikeDbContext
    {
        private readonly IMongoDatabase _database;

        public LikeDbContext(IMongoConfiguration configuration)
        {
            var client = new MongoClient(configuration.ConnectionString);

            _database = client.GetDatabase(MongoUrl.Create(configuration.ConnectionString).DatabaseName);
        }

        public IMongoCollection<Like> Likes => _database.GetCollection<Like>(nameof(Like));
    }
}