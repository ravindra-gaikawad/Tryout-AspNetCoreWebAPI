namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using QuoteAPI.Models;

    public interface ICategoryService
    {
        Category Get(int id);

        Category Find(Expression<Func<Category, bool>> predicate);

        IQueryable<Category> FindAll(Expression<Func<Category, bool>> predicate);

        IQueryable<Category> GetAll();

        void Add(Category entity);

        void Delete(Category entity);

        void Edit(Category entity);
    }
}
