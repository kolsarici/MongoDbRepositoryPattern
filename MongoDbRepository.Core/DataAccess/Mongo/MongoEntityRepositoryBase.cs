using MongoDB.Driver;
using MongoDbRepository.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MongoDbRepository.Core.DataAccess.Mongo
{
    public abstract class MongoEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly IMongoContext<TEntity> _context;
        protected readonly IMongoCollection<TEntity> _collection;

        protected MongoEntityRepositoryBase(IMongoContext<TEntity> context)
        {
            _context = context;
            _collection = _context.GetCollection();
        }

        public virtual async Task Add(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public virtual async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
                return (await _collection.FindAsync(Builders<TEntity>.Filter.Empty)).ToList();
            return (await _collection.FindAsync(Builders<TEntity>.Filter.Where(filter))).ToList();
        }

        public virtual async Task Update(TEntity entity)
        {
            await _collection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", entity.Id), entity);
        }

        public virtual async Task Delete(Guid id)
        {
            await _collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
