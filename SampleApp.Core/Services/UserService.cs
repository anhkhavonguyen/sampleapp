using System.Linq;
using SampleApp.Core.Messages;
using SampleApp.Core.DbContext;

namespace SampleApp.Core.Services
{
    public class UserService : IUserService
    {
        private UnitOfWork.IUnitOfWork _unitOfWork;
        public UserService(UnitOfWork.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(AddUserRequest request)
        {
            var user = new User();
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;

            _unitOfWork.UserRepository.Add(user);
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
