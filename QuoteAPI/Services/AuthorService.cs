using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;

namespace QuoteAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly QuoteDBContext context;

        public AuthorService(QuoteDBContext context)
        {
            this.context = context;
        }

        void IAuthorService.Add(Author entity)
        {
            context.Author.Add(entity);
            context.SaveChanges();
        }

        void IAuthorService.Delete(Author entity)
        {
            context.Author.Remove(entity);
            context.SaveChanges();
        }

        void IAuthorService.Edit(Author entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
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
            return context.Author.Find(id);
        }

        IQueryable<Author> IAuthorService.GetAll()
        {
            return context.Author;
        }
    }
}
