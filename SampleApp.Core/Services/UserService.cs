using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Messages;
using SampleApp.Core.Repositories;
using SampleApp.Core.DbContext;

namespace SampleApp.Core.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public GetUsersResponse GetUsers()
        {
            var users = _userRepository.GetUsers().ToList();
            return new GetUsersResponse()
            {
                Users = users
            };
        }
    }
}
