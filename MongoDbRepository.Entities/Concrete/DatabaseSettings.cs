using MongoDbRepository.Core.Entities;

namespace MongoDbRepository.Entities.Concrete
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
