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
    public class QuotesController : ControllerBase
    {
        private readonly QuoteDBContext _context;

        public QuotesController(QuoteDBContext context)
        {
            _context = context;
        }

        // GET: api/Quotes
        [HttpGet]
        public IEnumerable<Quote> GetQuote()
        {
            return _context.Quote;
        }

        // GET: api/Quotes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quote = await _context.Quote.FindAsync(id);

            if (quote == null)
            {
                return NotFound();
            }

            return Ok(quote);
        }

        // PUT: api/Quotes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuote([FromRoute] int id, [FromBody] Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quote.Id)
            {
                return BadRequest();
            }

            _context.Entry(quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(id))
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

        // POST: api/Quotes
        [HttpPost]
        public async Task<IActionResult> PostQuote([FromBody] Quote quote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Quote.Add(quote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuote", new { id = quote.Id }, quote);
        }

        // DELETE: api/Quotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quote = await _context.Quote.FindAsync(id);
            if (quote == null)
            {
                return NotFound();
            }

            _context.Quote.Remove(quote);
            await _context.SaveChangesAsync();

            return Ok(quote);
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.Id == id);
        }
    }
}