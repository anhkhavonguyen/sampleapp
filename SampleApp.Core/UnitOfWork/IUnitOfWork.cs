using SampleApp.Core.DbContext;
using SampleApp.Core.Models;
using SampleApp.Core.Repositories;
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

        IRepository<User> UserRepository { get; }
        IRepository<Article> ArticleRepository { get; }
        IRepository<Category> CategoryRepository { get; }
    }
}
