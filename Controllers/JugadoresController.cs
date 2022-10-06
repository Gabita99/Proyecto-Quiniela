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
    public class JugadoresController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public JugadoresController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/Jugadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jugadores>>> GetJugadores()
        {
            return await _context.Jugadores.ToListAsync();
        }

        // GET: api/Jugadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jugadores>> GetJugadores(int id)
        {
            var jugadores = await _context.Jugadores.FindAsync(id);

            if (jugadores == null)
            {
                return NotFound();
            }

            return jugadores;
        }

        // PUT: api/Jugadores/5
       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugadores(int id, Jugadores jugadores)
        {
            if (id != jugadores.idJugadores)
            {
                return BadRequest();
            }

            _context.Entry(jugadores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JugadoresExists(id))
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

        // POST: api/Jugadores
    
        [HttpPost]
        public async Task<ActionResult<Jugadores>> PostJugadores(Jugadores jugadores)
        {
            _context.Jugadores.Add(jugadores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJugadores", new { id = jugadores.idJugadores }, jugadores);
        }

        // DELETE: api/Jugadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugadores(int id)
        {
            var jugadores = await _context.Jugadores.FindAsync(id);
            if (jugadores == null)
            {
                return NotFound();
            }

            _context.Jugadores.Remove(jugadores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JugadoresExists(int id)
        {
            return _context.Jugadores.Any(e => e.idJugadores == id);
        }
    }
}
