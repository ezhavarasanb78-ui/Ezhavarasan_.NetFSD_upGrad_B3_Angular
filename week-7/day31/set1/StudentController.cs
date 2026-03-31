using Microsoft.AspNetCore.Mvc;
namespace Day31.Controllers
{
    public class StudentController: Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string name,int age,string course)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Course = course;
            return RedirectToAction("Display", new
            {
                name = name,
                age = age,
                course = course
            });
        }
        [HttpGet]
        public IActionResult Display(string name,int age,string course)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Course = course;
            return View();
        }
    }
}
