using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;

namespace QuoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly QuoteDBContext _context;

        public AuthorsController(QuoteDBContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public IEnumerable<Author> GetAuthor()
        {
            return _context.Author;
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var author = await _context.Author.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }

        // GET: api/Authors/5/Quotes
        [HttpGet("{id}/quotes")]
        public async Task<IActionResult> GetQuotesByAuthor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var author = await _context.Author.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            var quotes = from q in _context.Quote
                         where q.Author == author.Name
                         select q;

            return Ok(quotes);
        }

        // PUT: api/Authors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor([FromRoute] int id, [FromBody] Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != author.Id)
            {
                return BadRequest();
            }

            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
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

        // POST: api/Authors
        [HttpPost]
        public async Task<IActionResult> PostAuthor([FromBody] Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Author.Add(author);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var author = await _context.Author.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            _context.Author.Remove(author);
            await _context.SaveChangesAsync();

            return Ok(author);
        }

        private bool AuthorExists(int id)
        {
            return _context.Author.Any(e => e.Id == id);
        }
    }
}