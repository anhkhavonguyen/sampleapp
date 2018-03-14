using SampleApp.Core.DbContext;
using SampleApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SimpleAppContext _simpleAppContext = new SimpleAppContext();
        private Repository<User> userRepository;
        public UnitOfWork()
        {
        }

        public IRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new Repository<User>(_simpleAppContext);
                }
                return userRepository;
            }
        }

        public int Commit()
        {
            return _simpleAppContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_simpleAppContext != null)
                {
                    _simpleAppContext.Dispose();
                    _simpleAppContext = null;
                }
            }
        }

        IRepository<User> IUnitOfWork.UserRepository<T>()
        {
            return UserRepository;
        }
    }
}
