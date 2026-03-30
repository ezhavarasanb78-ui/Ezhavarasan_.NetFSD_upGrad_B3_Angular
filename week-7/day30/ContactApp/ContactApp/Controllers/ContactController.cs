using ContactApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        private static List<ContactInfo> cont = new List<ContactInfo>()
        {
            new ContactInfo { Id = 1, FirstName = "John", LastName = "Doe", CompanyName = "ABC Corp", EmailId = "john@gmail.com", MobileNo = 9876543210, Designation = "Manager" },
            new ContactInfo { Id = 2, FirstName = "Jane", LastName = "Smith", CompanyName = "XYZ Ltd", EmailId = "jane@gmail.com", MobileNo = 9123456780, Designation = "Developer" }
        };
        public IActionResult ShowContact()
        {
            return View(cont);
        }
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(ContactInfo ci)
        {
            cont.Add(ci);
            return RedirectToAction("ShowContact");
        }
        public IActionResult GetContactbyId(int id)
        {
            var contact = cont.FirstOrDefault(c => c.Id == id);
            if(contact==null)
            {
                ViewBag.Message = "Contact not found";
                return View();
            }
            return View(contact);
        }

    }
}
