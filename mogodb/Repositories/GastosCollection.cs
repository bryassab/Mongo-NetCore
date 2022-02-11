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
        }

        public Task<List<GastosModal>> GetallGastos()
        {
            throw new NotImplementedException();
        }

        public Task<GastosModal> GetGastoById(string id)
        {
            throw new NotImplementedException();
        }

        public Task InsertGasto(GastosModal gasto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGasto(GastosModal gasto)
        {
            throw new NotImplementedException();
        }
    }
}
