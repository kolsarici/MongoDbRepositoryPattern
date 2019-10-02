using MongoDbRepository.Core.DataAccess;
using MongoDbRepository.Entities.Concrete;

namespace MongoDbRepository.DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
    }
}
