using SampleApp.Core.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetUsers();
    }
}
