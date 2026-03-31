using Microsoft.AspNetCore.Mvc;
namespace Day31.Controllers
{
    public class FeedBackController:Controller
    {
        [HttpGet]
        public IActionResult Feed()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Feed(string name,string comments,int rating)
        {
            if(rating>=4)
            {
                ViewData["Message"] = "Thank you for your Feedback!";
            }
            else
            {
                ViewData["Message"] = "We will improve based on your feedback.";
            }
            return View();
        }
    }
}
