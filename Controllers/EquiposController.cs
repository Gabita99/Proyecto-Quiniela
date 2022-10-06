using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Quiniela.Context;
using Proyecto_Quiniela.Models;

namespace Proyecto_Quiniela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public EquiposController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/Equipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipos>>> Getequipos()
        {
            return await _context.equipos.ToListAsync();
        }

        // GET: api/Equipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipos>> GetEquipos(int id)
        {
            var equipos = await _context.equipos.FindAsync(id);

            if (equipos == null)
            {
                return NotFound();
            }

            return equipos;
        }

        // PUT: api/Equipos/5
      
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipos(int id, Equipos equipos)
        {
            if (id != equipos.Id)
            {
                return BadRequest();
            }

            _context.Entry(equipos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquiposExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Equipos
       
        [HttpPost]
        public async Task<ActionResult<Equipos>> PostEquipos(Equipos equipos)
        {
            _context.equipos.Add(equipos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipos", new { id = equipos.Id }, equipos);
        }

        // DELETE: api/Equipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipos(int id)
        {
            var equipos = await _context.equipos.FindAsync(id);
            if (equipos == null)
            {
                return NotFound();
            }

            _context.equipos.Remove(equipos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EquiposExists(int id)
        {
            return _context.equipos.Any(e => e.Id == id);
        }
    }
}
