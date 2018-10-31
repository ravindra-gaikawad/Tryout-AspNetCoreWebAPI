namespace QuoteAPI.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using QuoteAPI.Models;

    public class QuoteService : IQuoteService
    {
        private readonly QuoteDBContext context;

        public QuoteService(QuoteDBContext context)
        {
            this.context = context;
        }

        void IQuoteService.Add(Quote entity)
        {
            this.context.Quote.Add(entity);
            this.context.SaveChanges();
        }

        void IQuoteService.Delete(Quote entity)
        {
            this.context.Quote.Remove(entity);
            this.context.SaveChanges();
        }

        void IQuoteService.Edit(Quote entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        Quote IQuoteService.Find(Expression<Func<Quote, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Quote> IQuoteService.FindAll(Expression<Func<Quote, bool>> predicate)
        {
            return this.context.Quote.AsQueryable().Where(predicate);
        }

        Quote IQuoteService.Get(int id)
        {
            return this.context.Quote.Find(id);
        }

        IQueryable<Quote> IQuoteService.GetAll()
        {
            return this.context.Quote;
        }
    }
}
