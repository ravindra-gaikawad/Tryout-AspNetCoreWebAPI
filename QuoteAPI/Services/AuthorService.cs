namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using QuoteAPI.Models;
    using QuoteAPI.Repository;

    public class AuthorService : IAuthorService
    {
        private readonly IRepository repository;

        public AuthorService(IRepository repository)
        {
            this.repository = repository;
        }

        void IAuthorService.Add(Author entity)
        {
            this.repository.Add(entity);
        }

        void IAuthorService.Delete(Author entity)
        {
            this.repository.Delete(entity);
        }

        void IAuthorService.Edit(Author entity)
        {
            this.repository.Edit(entity);
        }

        Author IAuthorService.Find(Expression<Func<Author, bool>> predicate)
        {
            return this.repository.Find(predicate);
        }

        IQueryable<Author> IAuthorService.FindAll(Expression<Func<Author, bool>> predicate)
        {
            return this.repository.FindAll(predicate);
        }

        Author IAuthorService.Get(int id)
        {
            return this.repository.Get<Author>(id);
        }

        IQueryable<Author> IAuthorService.GetAll()
        {
            return this.repository.GetAll<Author>();
        }
    }
}
