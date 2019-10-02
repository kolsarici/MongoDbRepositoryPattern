using MongoDbRepository.Business.Abstract;
using MongoDbRepository.DataAccess.Abstract;
using MongoDbRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MongoDbRepository.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(Guid id)
        {
            _userDal.Delete(id);
        }

        public async Task<List<User>> GetList(Expression<Func<User, bool>> filter = null)
        {
            return await _userDal.GetList(filter);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
