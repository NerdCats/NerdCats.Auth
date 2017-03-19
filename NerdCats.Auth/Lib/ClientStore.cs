namespace NerdCats.Auth.Lib
{
    using System;
    using System.Threading.Tasks;
    using IdentityServer4.Models;

    using IdentityServer4.Stores;
    using NerdCats.Auth.Lib.Db;
    using MongoDB.Driver;

    public class ClientStore : IClientStore
    {
        private IDbContext dbContext;
        private IMongoCollection<Client> collection;

        public ClientStore(IDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.collection = dbContext.Clients;
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
