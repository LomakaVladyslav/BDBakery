using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cooking.Models;

namespace Cooking.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecieptsController : ControllerBase
    {
        private readonly CookingAPIContext _context;

        public RecieptsController(CookingAPIContext context)
        {
            _context = context;
        }

        // GET: api/Reciepts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reciept>>> GetReciepts()
        {
            return await _context.Reciepts.ToListAsync();
        }

        // GET: api/Reciepts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reciept>> GetReciept(int id)
        {
            var reciept = await _context.Reciepts.FindAsync(id);

            if (reciept == null)
            {
                return NotFound();
            }

            return reciept;
        }

        // PUT: api/Reciepts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReciept(int id, Reciept reciept)
        {
            if (id != reciept.Id)
            {
                return BadRequest();
            }

            _context.Entry(reciept).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecieptExists(id))
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

        // POST: api/Reciepts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reciept>> PostReciept(Reciept reciept)
        {
            _context.Reciepts.Add(reciept);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReciept", new { id = reciept.Id }, reciept);
        }

        // DELETE: api/Reciepts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReciept(int id)
        {
            var reciept = await _context.Reciepts.FindAsync(id);
            if (reciept == null)
            {
                return NotFound();
            }

            _context.Reciepts.Remove(reciept);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecieptExists(int id)
        {
            return _context.Reciepts.Any(e => e.Id == id);
        }
    }
}
