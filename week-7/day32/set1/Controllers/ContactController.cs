using Microsoft.AspNetCore.Mvc;
using DI.Models;
using DI.Services;
namespace DI.Controllers
{
    public class ContactController:Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult ShowContacts()
        {
            var contacts = _contactService.GetAllContacts();
            return View(contacts);
        }
        public IActionResult GetContactById(int id)
        {
            var contact = _contactService.GetContactById(id);
            return View(contact);
        }
        public IActionResult AddContacts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContacts(ContactInfo ci)

        {
            _contactService.AddContacts(ci);
            return RedirectToAction("ShowContacts");
        }
    }
}
