using SampleApp.Core.DbContext;
using SampleApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Models;

namespace SampleApp.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private SimpleAppContext _simpleAppContext = new SimpleAppContext();
        private Repository<User> userRepository;
        private Repository<Article> articleRepository;
        private Repository<Category> categoryRepository;

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

        public IRepository<Article> ArticleRepository
        {
            get
            {
                if (articleRepository == null)
                {
                    articleRepository = new Repository<Article>(_simpleAppContext);
                }
                return articleRepository;
            }
        }

        public IRepository<Category> CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new Repository<Category>(_simpleAppContext);
                }
                return categoryRepository;
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
    }
}
