using Userservice.Models;

namespace Userservice.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User?> GetByIdAsync(int id);

        Task<User?> GetByEmailAsync(string email);

        Task<User> AddAsync(User user);
    }
}
