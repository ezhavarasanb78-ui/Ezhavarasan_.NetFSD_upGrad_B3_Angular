using System;
using System.Collections.Generic;
using System.Text;
using Set1.Models;

namespace Set1.Services
{
    internal class ContactService:IContactService
    {

        private readonly List<Contact> _contacts = new();

        public void AddContact(Contact contact)
        {
            ValidateContact(contact);

            contact.Id = GenerateId();
            _contacts.Add(contact);
        }
        public void UpdateContact(int id, Contact updatedContact)
        {
            ValidateContact(updatedContact);

            var existing = FindContactById(id);

            existing.Name = updatedContact.Name;
            existing.Email = updatedContact.Email;
            existing.Phone = updatedContact.Phone;
        }

        public void DeleteContact(int id)
        {
            var contact = FindContactById(id);
            _contacts.Remove(contact);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }
        private Contact FindContactById(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null)
                throw new KeyNotFoundException($"Contact with Id {id} not found.");

            return contact;
        }

        private void ValidateContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            if (string.IsNullOrWhiteSpace(contact.Name))
                throw new ArgumentException("Name is required.");

            if (string.IsNullOrWhiteSpace(contact.Email))
                throw new ArgumentException("Email is required.");

            if (string.IsNullOrWhiteSpace(contact.Phone))
                throw new ArgumentException("Phone is required.");
        }

        private int GenerateId()
        {
            return _contacts.Count == 0 ? 1 : _contacts.Max(c => c.Id) + 1;
        }
    }
}
