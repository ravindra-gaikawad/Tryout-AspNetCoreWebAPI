namespace QuoteAPI.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using QuoteAPI.Models;
    using QuoteAPI.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IQuoteService quoteService;

        public CategoriesController(ICategoryService categoryService, IQuoteService quoteService)
        {
            this.categoryService = categoryService;
            this.quoteService = quoteService;
        }

        // GET: api/Categories
        [HttpGet]
        public IEnumerable<Category> GetCategory()
        {
            return this.categoryService.GetAll();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public IActionResult GetCategory([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var category = this.categoryService.Get(id);

            if (category == null)
            {
                return this.NotFound();
            }

            return this.Ok(category);
        }

        // GET: api/Categories/5/Quotes
        [HttpGet("{id}/quotes")]
        public IActionResult GetQuotesByCategory([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var category = this.categoryService.Get(id);

            if (category == null)
            {
                return this.NotFound();
            }

            var quotes = this.quoteService.FindAll(q => q.Category == category.Title);

            return this.Ok(quotes);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public IActionResult PutCategory([FromRoute] int id, [FromBody] Category category)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (id != category.Id)
            {
                return this.BadRequest();
            }

            this.categoryService.Edit(category);

            return this.NoContent();
        }

        // POST: api/Categories
        [HttpPost]
        public IActionResult PostCategory([FromBody] Category category)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.categoryService.Add(category);

            return this.CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var category = this.categoryService.Get(id);
            if (category == null)
            {
                return this.NotFound();
            }

            this.categoryService.Delete(category);

            return this.Ok(category);
        }
    }
}