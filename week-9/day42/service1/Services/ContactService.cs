using Contactservice.Models;
using Contactservice.Repositories;

namespace Contactservice.Services
{
    public class ContactService:IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Contact?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Contact contact)
        {
            
            await _repository.AddAsync(contact);
        }

        public async Task UpdateAsync(Contact contact)
        {
            await _repository.UpdateAsync(contact);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
