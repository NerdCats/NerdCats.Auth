namespace NerdCats.Auth.Lib.Db
{
    using MongoDB.Driver;
    public interface IDbContext
    {
        IMongoDatabase Database { get; }
    }
}
