using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MongoDbRepository.Core.DataAccess
{
    public interface IEntityRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);
        Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null);
        Task Update(TEntity entity);
        Task Delete(Guid id);
    }
}
