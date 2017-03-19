namespace NerdCats.Auth.Lib.Db
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;
    using IdentityServer4.Models;

    public class DbContext : IDbContext
    {
        private MongoClient mongoClient;
        public IMongoDatabase Database { get; private set; }

        public IMongoCollection<Client> Clients { get; private set; }

        public DbContext(string connectionString, string databaseName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException($"{nameof(connectionString)} is null or whitespace");

            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException($"{nameof(databaseName)} is null or whitespace");

            var mongoUrlBuilder = new MongoUrlBuilder(connectionString);
            mongoClient = new MongoClient(mongoUrlBuilder.ToMongoUrl());

            Database = mongoClient.GetDatabase(databaseName);

            InitiateCollectionReferences();
        }

        private void InitiateCollectionReferences()
        {
            this.Clients = this.Database.GetCollection<Client>(CollectionNames.Clients);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return Database.GetCollection<BsonDocument>(collectionName);
        }
    }
}
