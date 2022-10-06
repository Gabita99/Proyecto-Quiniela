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
    public class TipoResultadoesController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public TipoResultadoesController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/TipoResultadoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoResultado>>> GetTipoResultado()
        {
            return await _context.TipoResultado.ToListAsync();
        }

        // GET: api/TipoResultadoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoResultado>> GetTipoResultado(int id)
        {
            var tipoResultado = await _context.TipoResultado.FindAsync(id);

            if (tipoResultado == null)
            {
                return NotFound();
            }

            return tipoResultado;
        }

        // PUT: api/TipoResultadoes/5
      
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoResultado(int id, TipoResultado tipoResultado)
        {
            if (id != tipoResultado.idTipo)
            {
                return BadRequest();
            }

            _context.Entry(tipoResultado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoResultadoExists(id))
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

        // POST: api/TipoResultadoes
  
        [HttpPost]
        public async Task<ActionResult<TipoResultado>> PostTipoResultado(TipoResultado tipoResultado)
        {
            _context.TipoResultado.Add(tipoResultado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoResultado", new { id = tipoResultado.idTipo }, tipoResultado);
        }

        // DELETE: api/TipoResultadoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoResultado(int id)
        {
            var tipoResultado = await _context.TipoResultado.FindAsync(id);
            if (tipoResultado == null)
            {
                return NotFound();
            }

            _context.TipoResultado.Remove(tipoResultado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoResultadoExists(int id)
        {
            return _context.TipoResultado.Any(e => e.idTipo == id);
        }
    }
}
