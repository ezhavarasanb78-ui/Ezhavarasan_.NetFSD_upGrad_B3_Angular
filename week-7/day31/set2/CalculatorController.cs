using Microsoft.AspNetCore.Mvc;

namespace Day31.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(int num1,int num2)
        {
            int res = num1 + num2;
            ViewData["Result"] = res;
            return View();
        }
    }
}
