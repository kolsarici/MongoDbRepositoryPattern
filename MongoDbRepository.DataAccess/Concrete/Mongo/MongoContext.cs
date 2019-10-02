using MongoDB.Driver;
using MongoDbRepository.Core.DataAccess.Mongo;
using MongoDbRepository.Core.Entities;
using MongoDbRepository.Core.ExtensionMethods;

namespace MongoDbRepository.DataAccess.Concrete.Mongo
{
    public class MongoContext<TEntity> : IMongoContext<TEntity> where TEntity : class, new()
    {
        private readonly IMongoDatabase _database = null;
        public MongoContext(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoCollection<TEntity> GetCollection()
        {
            return _database.GetCollection<TEntity>(new TEntity().GetCollectionName());
        }
    }
}
