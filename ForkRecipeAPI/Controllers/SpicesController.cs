using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ForkRecipeAPI;
using ForkRecipeAPI.Data;

namespace ForkRecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpicesController : ControllerBase
    {
        private readonly RecipesContext _context;

        public SpicesController(RecipesContext context)
        {
            _context = context;
        }

        // GET: api/Spices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Spice>>> GetSpices()
        {
            return await _context.Spices.ToListAsync();
        }

        // GET: api/Spices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Spice>> GetSpice(int id)
        {
            var spice = await _context.Spices.FindAsync(id);

            if (spice == null)
            {
                return NotFound();
            }

            return spice;
        }

        // PUT: api/Spices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpice(int id, Spice spice)
        {
            if (id != spice.SpiceID)
            {
                return BadRequest();
            }

            _context.Entry(spice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpiceExists(id))
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

        // POST: api/Spices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Spice>> PostSpice(Spice spice)
        {
            _context.Spices.Add(spice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpice", new { id = spice.SpiceID }, spice);
        }

        // DELETE: api/Spices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Spice>> DeleteSpice(int id)
        {
            var spice = await _context.Spices.FindAsync(id);
            if (spice == null)
            {
                return NotFound();
            }

            _context.Spices.Remove(spice);
            await _context.SaveChangesAsync();

            return spice;
        }

        private bool SpiceExists(int id)
        {
            return _context.Spices.Any(e => e.SpiceID == id);
        }
    }
}
