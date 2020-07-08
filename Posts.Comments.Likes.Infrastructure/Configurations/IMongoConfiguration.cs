namespace Posts.Comments.Likes.Infrastructure.Configurations
{
    public interface IMongoConfiguration
    {
        string ConnectionString { get; set; }
    }
}