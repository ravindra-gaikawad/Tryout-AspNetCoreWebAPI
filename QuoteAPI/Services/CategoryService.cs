using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;

namespace QuoteAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly QuoteDBContext context;

        public CategoryService(QuoteDBContext context)
        {
            this.context = context;
        }

        void ICategoryService.Add(Category entity)
        {
            context.Category.Add(entity);
            context.SaveChanges();
        }

        void ICategoryService.Delete(Category entity)
        {
            context.Category.Remove(entity);
            context.SaveChanges();
        }

        void ICategoryService.Edit(Category entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        Category ICategoryService.Find<T>(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> ICategoryService.FindAll<T>(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Category ICategoryService.Get(int id)
        {
            return context.Category.Find(id);
        }

        IQueryable<Category> ICategoryService.GetAll()
        {
            return context.Category;
        }
    }
}
