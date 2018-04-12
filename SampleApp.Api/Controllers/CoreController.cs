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

namespace SampleApp.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/core")]
    public class CoreController : Controller
    {
        private IUserService _userService;
        public CoreController(IUserService userService)
        {
            _userService = userService;
        }

        #region User

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

        [HttpPut]
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

        #endregion


    }
}