using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuoteAPI.Models;

namespace QuoteAPI.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly QuoteDBContext context;

        public QuoteService(QuoteDBContext context)
        {
            this.context = context;
        }

        void IQuoteService.Add(Quote entity)
        {
            context.Quote.Add(entity);
            context.SaveChanges();
        }

        void IQuoteService.Delete(Quote entity)
        {
            context.Quote.Remove(entity);
            context.SaveChanges();
        }

        void IQuoteService.Edit(Quote entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        Quote IQuoteService.Find<T>(Expression<Func<Quote, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        IQueryable<Quote> IQuoteService.FindAll<T>(Expression<Func<Quote, bool>> predicate)
        {
            return context.Quote.AsQueryable().Where(predicate);
        }

        Quote IQuoteService.Get(int id)
        {
            return context.Quote.Find(id);
        }

        IQueryable<Quote> IQuoteService.GetAll()
        {
            return context.Quote;
        }
    }
}
