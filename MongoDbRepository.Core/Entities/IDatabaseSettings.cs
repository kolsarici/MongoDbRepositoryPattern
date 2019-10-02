using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbRepository.Core.Entities
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
