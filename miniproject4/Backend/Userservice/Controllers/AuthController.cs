using Microsoft.AspNetCore.Mvc;
using Userservice.DTOs;
using Userservice.Services;

namespace Userservice.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController
        : ControllerBase
    {
        private readonly IUserService
            _service;

        public AuthController(
            IUserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<
            IActionResult>
            Register(
                RegisterDto dto)
        {
            try
            {
                var result =
                    await _service
                    .RegisterAsync(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        message =
                            ex.Message
                    }
                );
            }
        }

        [HttpPost("login")]
        public async Task<
            IActionResult>
            Login(
                LoginDto dto)
        {
            try
            {
                var result =
                    await _service
                    .LoginAsync(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        message =
                            ex.Message
                    }
                );
            }
        }
    }
}