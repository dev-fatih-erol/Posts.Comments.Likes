namespace Posts.Comments.Likes.Infrastructure.Configurations
{
    public class MongoConfiguration : IMongoConfiguration
    {
        public string ConnectionString { get; set; }
    }
}