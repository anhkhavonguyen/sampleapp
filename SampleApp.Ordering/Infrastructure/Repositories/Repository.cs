using SampleApp.Ordering.DbContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleApp.Ordering.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private OrderingContext _orderingContext;
        private IDbSet<T> _dbSet;

        public Repository(OrderingContext orderingContext)
        {
            _orderingContext = orderingContext;
            _dbSet = _orderingContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Edit(T entity)
        {
            _orderingContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _orderingContext.Entry(entity).State = EntityState.Deleted;
        }
    }
}
