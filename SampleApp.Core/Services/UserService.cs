using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Messages;
using SampleApp.Core.Repositories;
using SampleApp.Core.DbContext;
using SampleApp.Core.UnitOfWork;

namespace SampleApp.Core.Services
{
    public class UserService : IUserService
    {
        private UnitOfWork.UnitOfWork _unitOfWork = null;
        public UserService()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }

        public GetUsersResponse GetUsers()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            return new GetUsersResponse()
            {
                Users = users
            };
        }
    }
}
