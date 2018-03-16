using SampleApp.Core.DbContext;
using SampleApp.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Services
{
    public interface IUserService
    {
        GetUsersResponse GetUsers ();
        void Add(AddUserRequest request);
        void Delete(User user);
        void Edit(User user);
    }
}
