using Microsoft.AspNetCore.Mvc;
using mogodb.Modals;
using mogodb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mogodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : Controller
    {
        private IGastosCollection db = new GastosCollection();
        
        [HttpGet]
        public async Task<IActionResult> GetAllGastos()
        {
            return Ok(await db.GetAllGastos());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGasto(string id)
        {
            return Ok(await db.GetGastoById(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateGasto([FromBody] GastosModal gasto)
        {
            if (gasto == null)
                return BadRequest();
            if (gasto.Nombre == string.Empty)
            {
                ModelState.AddModelError("Nombre", "El Nombre no puede estar vacio");
            }
            await db.InsertGasto(gasto);
            return Created("created", true);
              
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGasto([FromBody] GastosModal gasto, string id)
        {
            if (gasto == null)
                return BadRequest();
            if (gasto.Nombre == string.Empty)
            {
                ModelState.AddModelError("Nombre", "El Nombre no puede estar vacio");
            }
            gasto.Id = new MongoDB.Bson.ObjectId (id);
            await db.UpdateGasto(gasto);
            return Created("created", true);

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteGasto(string id)
        {
            await db.DeleteGasto(id);
            return NoContent();
        }
    }
}
