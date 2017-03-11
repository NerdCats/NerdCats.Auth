namespace NerdCats.Auth.Lib.Db
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using System;

    public class DbContext : IDbContext
    {
        private MongoClient mongoClient;
        public IMongoDatabase Database { get; private set; }

        public DbContext(string connectionString, string databaseName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException($"{nameof(connectionString)} is null or whitespace");

            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException($"{nameof(databaseName)} is null or whitespace");

            var mongoUrlBuilder = new MongoUrlBuilder(connectionString);
            mongoClient = new MongoClient(mongoUrlBuilder.ToMongoUrl());

            Database = mongoClient.GetDatabase(databaseName);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return Database.GetCollection<BsonDocument>(collectionName);
        }
    }
}
