using SampleApp.Ordering.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace SampleApp.Ordering.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private OrderingContext _orderingContext;
        private System.Data.Entity.IDbSet<T> _dbSet;

        public Repository(OrderingContext orderingContext)
        {
            _orderingContext = orderingContext;
            _dbSet = _orderingContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
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
            _orderingContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _orderingContext.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
        }
    }
}
