namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using QuoteAPI.Models;

    public class AuthorService : IAuthorService
    {
        private readonly QuoteDBContext context;

        public AuthorService(QuoteDBContext context)
        {
            this.context = context;
        }

        void IAuthorService.Add(Author entity)
        {
            this.context.Author.Add(entity);
            this.context.SaveChanges();
        }

        void IAuthorService.Delete(Author entity)
        {
            this.context.Author.Remove(entity);
            this.context.SaveChanges();
        }

        void IAuthorService.Edit(Author entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        Author IAuthorService.Find(Expression<Func<Author, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Author> IAuthorService.FindAll(Expression<Func<Author, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Author IAuthorService.Get(int id)
        {
            return this.context.Author.Find(id);
        }

        IQueryable<Author> IAuthorService.GetAll()
        {
            return this.context.Author;
        }
    }
}
