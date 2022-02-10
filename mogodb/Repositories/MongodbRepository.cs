using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mogodb.Repositories
{
    public class MongodbRepository
    {
        public MongoClient Client;

        public IMongoDatabase db;

        public MongodbRepository()
        {
            Client = new MongoClient("mongodb://brayan-shard-00-02.urcpd.mongodb.net:27017");

            db.Client.GetDatabase("Solicitudes");
        }

    }
}
