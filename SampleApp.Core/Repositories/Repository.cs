using SampleApp.Core.DbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SimpleAppContext _simpleAppContext;
        private IDbSet<T> _dbSet;

        public Repository(SimpleAppContext simpleAppContext)
        {
            _simpleAppContext = simpleAppContext;
            _dbSet = simpleAppContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable<T>();
        }
    }
}
