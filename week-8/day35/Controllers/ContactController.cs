using CMS.Models;
using CMS.Repository;
using Microsoft.AspNetCore.Mvc;
namespace CMS.Controllers
{
    public class ContactController:Controller
    {
        private readonly IContactRepository _repo;
        public ContactController(IContactRepository repo)
        {
            _repo = repo;
        }
        public IActionResult ShowContacts()
        {
            var contact = _repo.GetAll();
            return View(contact);
        }
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(ContactInfo ci)
        {
            _repo.AddContact(ci);
            return RedirectToAction("ShowContacts");
        }
        public IActionResult GetContactById(int id)
        {
            var contact = _repo.GetContactById(id);
            return View(contact);
        }
        public IActionResult EditContact(int id)
        {
            var contact = _repo.GetContactById(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult EditContact(ContactInfo ci)
        {
            _repo.EditContact(ci);
            return RedirectToAction("ShowContacts");
        }
        [HttpGet("delete/{id}")]
        public IActionResult DeleteContact(int id)
        {
            _repo.DeleteContact(id);
            return RedirectToAction("ShowContacts");
        }
    }
}
