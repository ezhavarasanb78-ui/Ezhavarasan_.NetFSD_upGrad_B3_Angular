using WebAPI.Models;
namespace WebAPI.DataAccess
{
    public interface IContactRepository
    {
        Task<IEnumerable<ContactInfo>> GetAllAsync();
        Task<ContactInfo> GetbyIdAsync(int id);
        Task<ContactInfo> AddAsync(ContactInfo ci);
        Task<bool> UpdateAsync(int id,ContactInfo ci);
        Task<bool> DeleteAsync(int id);
    }
}
