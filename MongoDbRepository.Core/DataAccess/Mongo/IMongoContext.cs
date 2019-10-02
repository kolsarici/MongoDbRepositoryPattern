using MongoDB.Driver;

namespace MongoDbRepository.Core.DataAccess.Mongo
{
    public interface IMongoContext<TEntity> where TEntity : class, new()
    {
        IMongoCollection<TEntity> GetCollection();
    }
}
