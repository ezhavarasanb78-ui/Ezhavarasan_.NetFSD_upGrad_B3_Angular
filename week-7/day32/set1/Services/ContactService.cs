using DI.Models;
namespace DI.Services
{
    public class ContactService :IContactService
    {
        private static List<ContactInfo> contacts = new List<ContactInfo>();

        public List<ContactInfo> GetAllContacts()
        {
            return contacts;
        }
        public ContactInfo GetContactById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);

        }
        public void AddContacts(ContactInfo ci)
        {
            contacts.Add(ci);
        }

    }
}
