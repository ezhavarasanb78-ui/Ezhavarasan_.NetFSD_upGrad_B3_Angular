using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ContactRepository:IContactRepository
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>();
        private static int _nextId=1;
        public async Task<IEnumerable<ContactInfo>>GetAllAsync()
        {
            return await Task.FromResult(contacts);
        }
        public async Task<ContactInfo> GetbyIdAsync(int id)
        {
            var contact = contacts.FirstOrDefault(x => x.ContactId == id);
            return await Task.FromResult(contact);
        }
        public async Task<ContactInfo> AddAsync(ContactInfo ci)
        {
            ci.ContactId = _nextId++;
            contacts.Add(ci);
            return await Task.FromResult(ci);
        }
        public async Task<bool> UpdateAsync(int id,ContactInfo ci)
        {
            var exist = contacts.FirstOrDefault(x => x.ContactId == id);
            if(exist ==null)
            {
                return await Task.FromResult(false);
            }
            
            exist.FirstName = ci.FirstName;
            exist.LastName = ci.LastName;
            exist.EmailId = ci.EmailId;
            exist.MobileNo = ci.MobileNo;
            exist.Designation = ci.Designation;
            exist.DepartmentId = ci.DepartmentId;
            exist.CompanyId = ci.CompanyId;
            return await Task.FromResult(true);
            
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var contact = contacts.FirstOrDefault(x => x.ContactId == id);
            if(contact==null)
            {
                return await Task.FromResult(false);
            }
            contacts.Remove(contact);
            return await Task.FromResult(true);

        }
    }
}
