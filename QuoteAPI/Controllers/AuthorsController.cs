using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;
using QuoteAPI.Services;

namespace QuoteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService authorService;
        private readonly IQuoteService quoteService;

        public AuthorsController(IAuthorService authorService,IQuoteService quoteService)
        {
            this.authorService = authorService;
            this.quoteService = quoteService;
        }

        // GET: api/Authors
        [HttpGet]
        public IEnumerable<Author> GetAuthor()
        {
            return authorService.GetAll();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var author = authorService.Get(id);

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

            var author = authorService.Get(id);

            if (author == null)
            {
                return NotFound();
            }

            var quotes = quoteService.FindAll(q => q.Author == author.Name);

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

            authorService.Edit(author);

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

            authorService.Add(author);

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

            var author = authorService.Get(id);
            if (author == null)
            {
                return NotFound();
            }

            authorService.Delete(author);

            return Ok(author);
        }
    }
}