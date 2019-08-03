using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TsSharp.Data;
using TsSharp.Models;

namespace TsSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly ApplicationContext db;

        public CatsController(ApplicationContext context)
        {
            db = context;
        }

        // GET: api/Cats
        [HttpGet]
        public IEnumerable<Cat> GetCats(int? parentId)
        {
            if (parentId.HasValue)
                return db.Cats.Where(x => x.ParentId == parentId).Include(x=>x.Cats);
            return db.Cats.Include(x => x.Cats);
        }

        // GET: api/Cats/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCat([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cat = await db.Cats.FindAsync(id);
            cat.Products = await db.Products.Where(p => p.CatId == cat.Id).ToListAsync();
            cat.Cats = await db.Cats.Where(x => x.ParentId == cat.Id).ToListAsync();
            if (cat == null)
            {
                return NotFound();
            }

            return Ok(cat);
        }

        // PUT: api/Cats/5
        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutCat([FromRoute] int id, [FromBody] Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cat.Id)
            {
                return BadRequest();
            }

            _context.Entry(cat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatExists(id))
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

        // POST: api/Cats
        [HttpPost]
        public async Task<IActionResult> PostCat([FromBody] Cat cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cats.Add(cat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCat", new { id = cat.Id }, cat);
        }

        // DELETE: api/Cats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCat([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cat = await _context.Cats.FindAsync(id);
            if (cat == null)
            {
                return NotFound();
            }

            _context.Cats.Remove(cat);
            await _context.SaveChangesAsync();

            return Ok(cat);
        }
        
        private bool CatExists(int id)
        {
            return _context.Cats.Any(e => e.Id == id);
        }
        */
    }
}