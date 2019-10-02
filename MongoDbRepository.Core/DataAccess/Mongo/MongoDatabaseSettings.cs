using MongoDbRepository.Core.Entities;

namespace MongoDbRepository.Core.DataAccess.Mongo
{
    public class MongoDatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
