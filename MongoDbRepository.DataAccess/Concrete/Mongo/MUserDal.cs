using MongoDbRepository.Core.DataAccess.Mongo;
using MongoDbRepository.DataAccess.Abstract;
using MongoDbRepository.Entities.Concrete;

namespace MongoDbRepository.DataAccess.Concrete.Mongo
{
    public class MUserDal: MongoEntityRepositoryBase<User>, IUserDal
    {
        public MUserDal(IMongoContext<User> context) : base(context)
        {
        }
    }
}
