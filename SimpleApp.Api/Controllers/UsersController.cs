using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Core.DbContext;
using SampleApp.Core.Messages;
using SampleApp.Core.Services;
using SampleApp.Core.UnitOfWork;

namespace SimpleApp.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
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

        [HttpPost]
        public IActionResult Add([FromBody] AddUserRequest request)
        {
            _userService.Add(request);
            return Ok();
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _userService.Edit(user);
            return Ok();
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            _userService.Delete(user);
            return Ok();
        }
    }
}