using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Userservice.Services;

namespace Userservice.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController:ControllerBase
    {
         private readonly IUserService _service;
            public UserController(IUserService service)
            {
                _service = service;
            }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _service.GetAllUsersAsync();
            return Ok(users);
        }
    }
}
