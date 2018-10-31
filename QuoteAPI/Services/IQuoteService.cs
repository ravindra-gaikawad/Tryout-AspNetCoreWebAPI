using QuoteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QuoteAPI.Services
{
    public interface IQuoteService
    {
        Quote Get(int id);

        Quote Find<T>(Expression<Func<Quote, bool>> predicate);

        IQueryable<Quote> FindAll<T>(Expression<Func<Quote, bool>> predicate);

        IQueryable<Quote> GetAll();

        void Add(Quote entity);

        void Delete(Quote entity);

        void Edit(Quote entity);
    }
}
