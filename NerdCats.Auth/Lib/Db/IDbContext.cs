namespace NerdCats.Auth.Lib.Db
{
    using IdentityServer4.Models;
    using MongoDB.Driver;

    public interface IDbContext
    {
        IMongoDatabase Database { get; }
        IMongoCollection<Client> Clients { get; }
    }
}
