using SampleApp.Core.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Repositories
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        private SimpleAppContext _simpleAppContext;
        public UserRepository(SimpleAppContext simpleAppContext) : base(simpleAppContext)
        {
            _simpleAppContext = simpleAppContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _simpleAppContext.Users.AsEnumerable();
        }
    }
}
