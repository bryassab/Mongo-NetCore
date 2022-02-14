using mogodb.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mogodb.Repositories
{
    public interface IGastosCollection
    {
        Task InsertGasto(GastosModal gasto);
        Task UpdateGasto(GastosModal gasto);
        Task DeleteGasto(string id);
        Task<List<GastosModal>> GetAllGastos();
        Task<GastosModal> GetGastoById(string id);
    }
}
