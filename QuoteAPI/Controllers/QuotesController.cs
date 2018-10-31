using Microsoft.AspNetCore.Mvc;
using QuoteAPI.Models;
using QuoteAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private readonly IQuoteService quoteService;

        public QuotesController(IQuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        // GET: api/Quotes
        [HttpGet]
        public IEnumerable<Quote> GetQuote()
        {
            return quoteService.GetAll();
        }

        // GET: api/Quotes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuote([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var quote = quoteService.Get(id);

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

            quoteService.Edit(quote);

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

            quoteService.Add(quote);

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

            var quote = quoteService.Get(id);
            if (quote == null)
            {
                return NotFound();
            }

            quoteService.Delete(quote);

            return Ok(quote);
        }
    }
}