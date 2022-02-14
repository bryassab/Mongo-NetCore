using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mogodb.Repositories
{
    public class MongoDbRepository
    {
        public MongoClient Client;

        public IMongoDatabase db;

        public MongoDbRepository()
        {
            Client = new MongoClient("mongodb://localhost:27017");

            db = Client.GetDatabase("Viaje");
        }
    }
}
