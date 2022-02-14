using mogodb.Modals;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mogodb.Repositories
{
    public class GastosCollection : IGastosCollection
    {
        internal MongoDbRepository _repository = new MongoDbRepository();
        private IMongoCollection<GastosModal> Collection;

        public GastosCollection ()
        {
            Collection = _repository.db.GetCollection<GastosModal>("Gastos");
        }
        public async Task DeleteGasto(string id)
        {
            var filter = Builders<GastosModal>.Filter.Eq(x => x.Id, new ObjectId(id));
            await Collection.DeleteOneAsync(filter);
        }

        public async Task<List<GastosModal>> GetAllGastos()
        {
            return await Collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<GastosModal> GetGastoById(string id)
        {
            return await Collection.FindAsync(
                new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task InsertGasto(GastosModal gasto)
        {
            await Collection.InsertOneAsync(gasto);
        }

        public async Task UpdateGasto(GastosModal gasto)
        {
            var filter = Builders<GastosModal>.Filter.Eq(x => x.Id, gasto.Id);

            await Collection.ReplaceOneAsync(filter,gasto);
        }
    }
}
