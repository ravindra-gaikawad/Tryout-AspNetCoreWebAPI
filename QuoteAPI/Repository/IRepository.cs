namespace QuoteAPI.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using QuoteAPI.Models;

    public interface IRepository
    {
        T Get<T>(int id)
            where T : BaseEntity;

        IQueryable<T> GetAll<T>()
            where T : BaseEntity;

        T Find<T>(Expression<Func<T, bool>> predicate)
            where T : BaseEntity;

        IQueryable<T> FindAll<T>(Expression<Func<T, bool>> predicate)
            where T : BaseEntity;

        void Add<T>(T entity)
            where T : BaseEntity;

        void Delete<T>(T entity)
            where T : BaseEntity;

        void Edit<T>(T entity)
            where T : BaseEntity;
    }
}
