using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mogodb.Data.Configuration
{
    public class MongoSetting : IMongoSetting
    {
        public string GastosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }

    public interface IMongoSetting
    {
        string GastosCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
