using Userservice.DTOs;
using Userservice.Models;

namespace Userservice.Services
{
    public interface IUserService
    {
        Task<UserResponseDto>RegisterAsync(RegisterDto dto);
        Task<UserResponseDto> LoginAsync(LoginDto dto);
        Task<IEnumerable<UserResponseDto>> GetAllUsersAsync();
    }
}
