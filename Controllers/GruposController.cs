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
    public class GruposController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public GruposController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/Grupos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grupos>>> GetGrupos()
        {
            return await _context.Grupos.ToListAsync();
        }

        // GET: api/Grupos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grupos>> GetGrupos(int id)
        {
            var grupos = await _context.Grupos.FindAsync(id);

            if (grupos == null)
            {
                return NotFound();
            }

            return grupos;
        }

        // PUT: api/Grupos/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupos(int id, Grupos grupos)
        {
            if (id != grupos.idGrupo)
            {
                return BadRequest();
            }

            _context.Entry(grupos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GruposExists(id))
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

        // POST: api/Grupos
      
        [HttpPost]
        public async Task<ActionResult<Grupos>> PostGrupos(Grupos grupos)
        {
            _context.Grupos.Add(grupos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGrupos", new { id = grupos.idGrupo }, grupos);
        }

        // DELETE: api/Grupos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrupos(int id)
        {
            var grupos = await _context.Grupos.FindAsync(id);
            if (grupos == null)
            {
                return NotFound();
            }

            _context.Grupos.Remove(grupos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GruposExists(int id)
        {
            return _context.Grupos.Any(e => e.idGrupo == id);
        }
    }
}
