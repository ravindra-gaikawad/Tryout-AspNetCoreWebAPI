namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using QuoteAPI.Models;
    using QuoteAPI.Repository;

    public class CategoryService : ICategoryService
    {
        private readonly IRepository repository;

        public CategoryService(IRepository repository)
        {
            this.repository = repository;
        }

        void ICategoryService.Add(Category entity)
        {
            this.repository.Add(entity);
        }

        void ICategoryService.Delete(Category entity)
        {
            this.repository.Delete(entity);
        }

        void ICategoryService.Edit(Category entity)
        {
            this.repository.Edit(entity);
        }

        Category ICategoryService.Find(Expression<Func<Category, bool>> predicate)
        {
            return this.repository.Find(predicate);
        }

        IQueryable<Category> ICategoryService.FindAll(Expression<Func<Category, bool>> predicate)
        {
            return this.repository.FindAll(predicate);
        }

        Category ICategoryService.Get(int id)
        {
            return this.repository.Get<Category>(id);
        }

        IQueryable<Category> ICategoryService.GetAll()
        {
            return this.repository.GetAll<Category>();
        }
    }
}
