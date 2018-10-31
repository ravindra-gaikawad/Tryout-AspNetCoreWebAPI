namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using QuoteAPI.Models;

    public class CategoryService : ICategoryService
    {
        private readonly QuoteDBContext context;

        public CategoryService(QuoteDBContext context)
        {
            this.context = context;
        }

        void ICategoryService.Add(Category entity)
        {
            this.context.Category.Add(entity);
            this.context.SaveChanges();
        }

        void ICategoryService.Delete(Category entity)
        {
            this.context.Category.Remove(entity);
            this.context.SaveChanges();
        }

        void ICategoryService.Edit(Category entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        Category ICategoryService.Find(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> ICategoryService.FindAll(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Category ICategoryService.Get(int id)
        {
            return this.context.Category.Find(id);
        }

        IQueryable<Category> ICategoryService.GetAll()
        {
            return this.context.Category;
        }
    }
}
