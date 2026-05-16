using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Userservice.DTOs;
using Userservice.Models;
using Userservice.Repositories;

namespace Userservice.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repo;

        private readonly IConfiguration
            _configuration;

        public UserService(
            IUserRepository repo,
            IConfiguration configuration)
        {
            _repo = repo;
            _configuration =
                configuration;
        }

        public async Task<UserResponseDto> RegisterAsync(RegisterDto dto)
        {
            var existing =
                await _repo
                .GetByEmailAsync(dto.Email);

            if (existing != null)
            {
                throw new Exception
                    ("Email already exists");
            }

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash =
                BCrypt.Net.BCrypt.HashPassword
                (dto.Password),
                Role = "User"
            };

            await _repo.AddAsync(user);

            return new UserResponseDto
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role
            };
        }

        public async Task<UserResponseDto>
            LoginAsync(LoginDto dto)
        {
            var user =
                await _repo
                .GetByEmailAsync(dto.Email);

            if (user == null ||
                !BCrypt.Net.BCrypt
                .Verify(dto.Password,
                user.PasswordHash))
            {
                throw new Exception
                    ("Invalid credentials");
            }

            var token =
                GenerateJwtToken(user);

            return new UserResponseDto
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                Token = token
            };
        }

        public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
        {
            var users = await _repo.GetAllAsync();

            return users.Select(u => new UserResponseDto
            {
                UserId = u.UserId,
                Name = u.Name,
                Email = u.Email,
                Role = u.Role
            });
        }

        private string
            GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim
                (ClaimTypes.NameIdentifier,
                user.UserId.ToString()),

                new Claim
                (ClaimTypes.Email,
                user.Email),

                new Claim
                (ClaimTypes.Role,
                user.Role)
            };

            var key =
                new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _configuration["Jwt:Key"]!
                ));

            var creds =
                new SigningCredentials(
                    key,
                    SecurityAlgorithms
                    .HmacSha256);

            var token =
                new JwtSecurityToken(
                    issuer:
                    _configuration
                    ["Jwt:Issuer"],

                    audience:
                    _configuration
                    ["Jwt:Audience"],

                    claims: claims,

                    expires:
                    DateTime.Now
                    .AddDays(1),

                    signingCredentials:
                    creds
                );

            return new
                JwtSecurityTokenHandler()
                .WriteToken(token);
        }
    }
}
