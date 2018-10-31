namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using QuoteAPI.Models;

    public interface IQuoteService
    {
        Quote Get(int id);

        Quote Find(Expression<Func<Quote, bool>> predicate);

        IQueryable<Quote> FindAll(Expression<Func<Quote, bool>> predicate);

        IQueryable<Quote> GetAll();

        void Add(Quote entity);

        void Delete(Quote entity);

        void Edit(Quote entity);
    }
}
