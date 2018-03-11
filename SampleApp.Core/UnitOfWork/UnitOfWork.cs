using SampleApp.Core.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SimpleAppContext _simpleAppContext;

        public UnitOfWork(SimpleAppContext simpleAppContext)
        {
            _simpleAppContext = simpleAppContext;
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
    }
}
