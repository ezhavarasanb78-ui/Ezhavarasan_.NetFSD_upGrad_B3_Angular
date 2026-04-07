using CMS.Models;

namespace CMS.Repository
{
    public interface IContactRepository
    {
        IEnumerable<ContactInfo> GetAll();
        ContactInfo GetContactById(int id);
        void AddContact(ContactInfo c);
        void EditContact(ContactInfo c);
        void DeleteContact(int id);
        IEnumerable<Company> GetCompanies();
        IEnumerable<Department> GetDepartments();
    }
}
