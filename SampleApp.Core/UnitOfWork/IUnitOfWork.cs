using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
