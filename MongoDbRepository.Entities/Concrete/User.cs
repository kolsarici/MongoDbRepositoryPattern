using MongoDbRepository.Core.Entities;
using System;

namespace MongoDbRepository.Entities.Concrete
{
    [Collection("Users")] //CollectionName which is stored in MongoDB
    public class User: IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
