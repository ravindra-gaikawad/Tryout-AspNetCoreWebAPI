namespace QuoteAPI.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using QuoteAPI.Models;
    using QuoteAPI.Services;

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
            return this.quoteService.GetAll();
        }

        // GET: api/Quotes/5
        [HttpGet("{id}")]
        public IActionResult GetQuote([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var quote = this.quoteService.Get(id);

            if (quote == null)
            {
                return this.NotFound();
            }

            return this.Ok(quote);
        }

        // PUT: api/Quotes/5
        [HttpPut("{id}")]
        public IActionResult PutQuote([FromRoute] int id, [FromBody] Quote quote)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != quote.Id)
            {
                return this.BadRequest();
            }

            this.quoteService.Edit(quote);

            return this.NoContent();
        }

        // POST: api/Quotes
        [HttpPost]
        public IActionResult PostQuote([FromBody] Quote quote)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.quoteService.Add(quote);

            return this.CreatedAtAction("GetQuote", new { id = quote.Id }, quote);
        }

        // DELETE: api/Quotes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteQuote([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var quote = this.quoteService.Get(id);
            if (quote == null)
            {
                return this.NotFound();
            }

            this.quoteService.Delete(quote);

            return this.Ok(quote);
        }
    }
}