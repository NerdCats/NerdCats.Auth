namespace NerdCats.Auth.Lib
{
    using System;
    using System.Threading.Tasks;
    using IdentityServer4.Models;

    using IdentityServer4.Stores;
    using NerdCats.Auth.Lib.Db;

    public class ClientStore : IClientStore
    {
        private IDbContext dbContext;

        public ClientStore(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}
