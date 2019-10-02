using MongoDbRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MongoDbRepository.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Delete(Guid id);
        Task<List<User>> GetList(Expression<Func<User, bool>> filter = null);
        void Update(User user);
    }
}
