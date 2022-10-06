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
    public class TipoPremiosController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public TipoPremiosController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/TipoPremios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoPremios>>> GetTipoPremios()
        {
            return await _context.TipoPremios.ToListAsync();
        }

        // GET: api/TipoPremios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoPremios>> GetTipoPremios(int id)
        {
            var tipoPremios = await _context.TipoPremios.FindAsync(id);

            if (tipoPremios == null)
            {
                return NotFound();
            }

            return tipoPremios;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoPremios(int id, TipoPremios tipoPremios)
        {
            if (id != tipoPremios.idTipo)
            {
                return BadRequest();
            }

            _context.Entry(tipoPremios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPremiosExists(id))
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

        // POST: api/TipoPremios

        [HttpPost]
        public async Task<ActionResult<TipoPremios>> PostTipoPremios(TipoPremios tipoPremios)
        {
            _context.TipoPremios.Add(tipoPremios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoPremios", new { id = tipoPremios.idTipo }, tipoPremios);
        }

        // DELETE: api/TipoPremios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoPremios(int id)
        {
            var tipoPremios = await _context.TipoPremios.FindAsync(id);
            if (tipoPremios == null)
            {
                return NotFound();
            }

            _context.TipoPremios.Remove(tipoPremios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoPremiosExists(int id)
        {
            return _context.TipoPremios.Any(e => e.idTipo == id);
        }
    }
}
