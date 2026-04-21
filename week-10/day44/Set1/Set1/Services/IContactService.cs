using Set1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Set1.Services
{
    internal interface IContactService
    {
        void AddContact(Contact contact);
        void UpdateContact(int id, Contact contact);
        void DeleteContact(int id);
        IEnumerable<Contact> GetAllContacts();
    }
}
