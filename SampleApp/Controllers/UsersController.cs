using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Core.Messages;
using SampleApp.Core.Services;

namespace SimpleApp.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public GetUsersResponse Get()
        {
            return _userService.GetUsers();
        }
    }
}
