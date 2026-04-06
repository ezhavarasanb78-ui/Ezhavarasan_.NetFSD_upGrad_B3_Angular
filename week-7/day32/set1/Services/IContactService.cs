using DI.Models;
namespace DI.Services
{
    public interface IContactService
    {
        List<ContactInfo> GetAllContacts();
        ContactInfo GetContactById(int id);
        void AddContacts(ContactInfo ci);
    }
}
