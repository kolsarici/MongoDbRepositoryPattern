using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDbRepository.Core.Entities
{
    public interface IEntity
    {
        [BsonId]
        Guid Id { get; set; }
    }
}
