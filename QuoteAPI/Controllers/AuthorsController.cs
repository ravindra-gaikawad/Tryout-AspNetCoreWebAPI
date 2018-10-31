namespace QuoteAPI.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using QuoteAPI.Models;
    using QuoteAPI.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService authorService;
        private readonly IQuoteService quoteService;

        public AuthorsController(IAuthorService authorService, IQuoteService quoteService)
        {
            this.authorService = authorService;
            this.quoteService = quoteService;
        }

        // GET: api/Authors
        [HttpGet]
        public IEnumerable<Author> GetAuthor()
        {
            return this.authorService.GetAll();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public IActionResult GetAuthor([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var author = this.authorService.Get(id);

            if (author == null)
            {
                return this.NotFound();
            }

            return this.Ok(author);
        }

        // GET: api/Authors/5/Quotes
        [HttpGet("{id}/quotes")]
        public IActionResult GetQuotesByAuthor([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var author = this.authorService.Get(id);

            if (author == null)
            {
                return this.NotFound();
            }

            var quotes = this.quoteService.FindAll(q => q.Author == author.Name);

            return this.Ok(quotes);
        }

        // PUT: api/Authors/5
        [HttpPut("{id}")]
        public IActionResult PutAuthor([FromRoute] int id, [FromBody] Author author)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != author.Id)
            {
                return this.BadRequest();
            }

            this.authorService.Edit(author);

            return this.NoContent();
        }

        // POST: api/Authors
        [HttpPost]
        public IActionResult PostAuthor([FromBody] Author author)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.authorService.Add(author);

            return this.CreatedAtAction("GetAuthor", new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var author = this.authorService.Get(id);
            if (author == null)
            {
                return this.NotFound();
            }

            this.authorService.Delete(author);

            return this.Ok(author);
        }
    }
}