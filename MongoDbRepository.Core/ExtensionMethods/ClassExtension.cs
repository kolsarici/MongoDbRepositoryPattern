using MongoDbRepository.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbRepository.Core.ExtensionMethods
{
    public static class ClassExtension
    {
        public static string GetCollectionName<T>(this T entity) where T : class, new()
        {
            var collection = (Collection)Attribute.GetCustomAttribute(typeof(T), typeof(Collection));
            return collection.Name;
        }
    }
}
