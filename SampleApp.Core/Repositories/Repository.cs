using SampleApp.Core.DbContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SampleApp.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SimpleAppContext _simpleAppContext;
        private IDbSet<T> _dbSet;

        public Repository(SimpleAppContext simpleAppContext)
        {
            _simpleAppContext = simpleAppContext;
            _dbSet = _simpleAppContext.Set<T>();
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
            _simpleAppContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _simpleAppContext.Entry(entity).State = EntityState.Deleted;
        }
    }
}
