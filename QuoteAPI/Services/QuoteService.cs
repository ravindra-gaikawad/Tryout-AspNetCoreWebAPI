namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using QuoteAPI.Models;
    using QuoteAPI.Repository;

    public class QuoteService : IQuoteService
    {
        private readonly IRepository repository;

        public QuoteService(IRepository repository)
        {
            this.repository = repository;
        }

        void IQuoteService.Add(Quote entity)
        {
            this.repository.Add(entity);
        }

        void IQuoteService.Delete(Quote entity)
        {
            this.repository.Delete(entity);
        }

        void IQuoteService.Edit(Quote entity)
        {
            this.repository.Edit(entity);
        }

        Quote IQuoteService.Find(Expression<Func<Quote, bool>> predicate)
        {
            return this.repository.Find(predicate);
        }

        IQueryable<Quote> IQuoteService.FindAll(Expression<Func<Quote, bool>> predicate)
        {
            return this.repository.FindAll(predicate);
        }

        Quote IQuoteService.Get(int id)
        {
            return this.repository.Get<Quote>(id);
        }

        IQueryable<Quote> IQuoteService.GetAll()
        {
            return this.repository.GetAll<Quote>();
        }
    }
}
