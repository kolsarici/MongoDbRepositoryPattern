using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbRepository.Core.Entities
{
    public class Collection : Attribute
    {
        private string _name = "";

        public Collection(string name)
        {
            this._name = name;
        }

        public virtual string Name
        {
            get { return _name; }
        }
    }
}
