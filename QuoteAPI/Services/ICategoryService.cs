using QuoteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuoteAPI.Services
{
    public interface ICategoryService
    {
        Category Get(int id);

        Category Find<T>(Expression<Func<Category, bool>> predicate);

        IQueryable<Category> FindAll<T>(Expression<Func<Category, bool>> predicate);

        IQueryable<Category> GetAll();

        void Add(Category entity);

        void Delete(Category entity);

        void Edit(Category entity);
    }
}
