using System.Linq;
using SampleApp.Core.Messages;
using SampleApp.Core.DbContext;
using SampleApp.Logging.Services;
using System;
using SampleApp.Logging.Messages;
using SampleApp.Core.Exceptions;

namespace SampleApp.Core.Services
{
    public class UserService : IUserService
    {
        private UnitOfWork.IUnitOfWork _unitOfWork;
        private ILoggingService _loggingService;

        public UserService(UnitOfWork.IUnitOfWork unitOfWork, ILoggingService loggingService)
        {
            _unitOfWork = unitOfWork;
            _loggingService = loggingService;
        }

        public void Add(AddUserRequest request)
        {
            try
            {
                var user = new User();
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;

                _unitOfWork.UserRepository.Add(user);
            }
            catch (Exception ex)
            {
                var error = new LogErrorRequest();
                error.Type = Logging.TypeProgramLog.Server;
                error.ErrorMessage = ex.Message;
                _loggingService.LogError(error);

                throw new UnhandleException(ex.Message);
            }
        }

        public void Delete(User user)
        {
            _unitOfWork.UserRepository.Delete(user);
        }

        public void Edit(User user)
        {
            _unitOfWork.UserRepository.Edit(user);
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
