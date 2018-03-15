﻿using System;
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
        private UnitOfWork.IUnitOfWork _unitOfWork;
        public UserService(UnitOfWork.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
