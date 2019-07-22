using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Authentication.Services;
//using Authentication.Entities;
using System.Collections.Generic;
using static DataLibrary.DataAccess.SqlDataAccess;
using DataLibrary.Models;

namespace Authentication.Controllers
{
  [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        private List<User> users = new List<User>();

        public UsersController(IUserService userService)
        {
            _userService = userService;

            // cdg debug make some test users
            users = LoadUsers();

            if (users.Count < 2)
            {
                users.Add(new User
                {
                    Username = "cian",
                    Password = "123",
                    //Role = "Employee"
                });

                users.Add(new User
                {
                    Username = "admin",
                    Password = "admin",
                    //Role = "Administrator"
                });

                foreach (var user in users)
                    SaveUser(user);
            }
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = _userService.Authenticate(userParam.Username, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users =  _userService.GetAll();
            return Ok(users);
        }
    }
}
