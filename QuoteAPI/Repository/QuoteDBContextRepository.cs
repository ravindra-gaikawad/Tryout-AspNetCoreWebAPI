namespace QuoteAPI.Repository
{
    using System;
    using System.Collections.Generic;
    
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public class QuoteDBContextRepository : IRepository
    {
        private readonly DbContext dbContext;

        public QuoteDBContextRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        void IRepository.Add<T>(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
            this.dbContext.SaveChanges();
        }

        void IRepository.Delete<T>(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
            this.dbContext.SaveChanges();
        }

        void IRepository.Edit<T>(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
            this.dbContext.SaveChanges();
        }

        T IRepository.Find<T>(Expression<Func<T, bool>> predicate)
        {
            return this.dbContext.Set<T>().AsQueryable().Where(predicate).FirstOrDefault();
        }

        IQueryable<T> IRepository.FindAll<T>(Expression<Func<T, bool>> predicate)
        {
            return this.dbContext.Set<T>().AsQueryable().Where(predicate);
        }

        T IRepository.Get<T>(int id)
        {
            return this.dbContext.Set<T>().Find(id);
        }

        IQueryable<T> IRepository.GetAll<T>()
        {
            return this.dbContext.Set<T>().AsQueryable();
        }
    }
}
