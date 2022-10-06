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
    public class JuegosController : ControllerBase
    {
        private readonly ConexionSQLServer _context;

        public JuegosController(ConexionSQLServer context)
        {
            _context = context;
        }

        // GET: api/Juegos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Juegos>>> GetJuegos()
        {
            return await _context.Juegos.ToListAsync();
        }

        // GET: api/Juegos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Juegos>> GetJuegos(int id)
        {
            var juegos = await _context.Juegos.FindAsync(id);

            if (juegos == null)
            {
                return NotFound();
            }

            return juegos;
        }

        // PUT: api/Juegos/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJuegos(int id, Juegos juegos)
        {
            if (id != juegos.idJuegos)
            {
                return BadRequest();
            }

            _context.Entry(juegos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JuegosExists(id))
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

        // POST: api/Juegos
       
        [HttpPost]
        public async Task<ActionResult<Juegos>> PostJuegos(Juegos juegos)
        {
            _context.Juegos.Add(juegos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJuegos", new { id = juegos.idJuegos }, juegos);
        }

        // DELETE: api/Juegos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJuegos(int id)
        {
            var juegos = await _context.Juegos.FindAsync(id);
            if (juegos == null)
            {
                return NotFound();
            }

            _context.Juegos.Remove(juegos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JuegosExists(int id)
        {
            return _context.Juegos.Any(e => e.idJuegos == id);
        }
    }
}
