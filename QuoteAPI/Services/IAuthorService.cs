using QuoteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuoteAPI.Services
{
    public interface IAuthorService
    {
        Author Get(int id);

        Author Find(Expression<Func<Author, bool>> predicate);

        IQueryable<Author> FindAll(Expression<Func<Author, bool>> predicate);

        IQueryable<Author> GetAll();

        void Add(Author entity);

        void Delete(Author entity);

        void Edit(Author entity);
    }
}
