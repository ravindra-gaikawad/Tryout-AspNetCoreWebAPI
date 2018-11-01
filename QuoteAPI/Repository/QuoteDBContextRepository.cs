namespace QuoteAPI.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
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
        }

        void IRepository.Delete<T>(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }

        void IRepository.Edit<T>(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
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
