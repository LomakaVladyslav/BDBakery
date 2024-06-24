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
    public class AuthorRecieptsController : ControllerBase
    {
        private readonly CookingAPIContext _context;

        public AuthorRecieptsController(CookingAPIContext context)
        {
            _context = context;
        }

        // GET: api/AuthorReciepts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorReciept>>> GetAuthorReciepts()
        {
            return await _context.AuthorReciepts.ToListAsync();
        }

        // GET: api/AuthorReciepts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorReciept>> GetAuthorReciept(int id)
        {
            var authorReciept = await _context.AuthorReciepts.FindAsync(id);

            if (authorReciept == null)
            {
                return NotFound();
            }

            return authorReciept;
        }

        // PUT: api/AuthorReciepts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthorReciept(int id, AuthorReciept authorReciept)
        {
            if (id != authorReciept.Id)
            {
                return BadRequest();
            }

            _context.Entry(authorReciept).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorRecieptExists(id))
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

        // POST: api/AuthorReciepts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AuthorReciept>> PostAuthorReciept(AuthorReciept authorReciept)
        {
            _context.AuthorReciepts.Add(authorReciept);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthorReciept", new { id = authorReciept.Id }, authorReciept);
        }

        // DELETE: api/AuthorReciepts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthorReciept(int id)
        {
            var authorReciept = await _context.AuthorReciepts.FindAsync(id);
            if (authorReciept == null)
            {
                return NotFound();
            }

            _context.AuthorReciepts.Remove(authorReciept);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthorRecieptExists(int id)
        {
            return _context.AuthorReciepts.Any(e => e.Id == id);
        }
    }
}
