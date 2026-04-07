using Microsoft.AspNetCore.Mvc;
using StudentCourseSystem.Repository;
namespace StudentCourseSystem.Controllers
{
    public class CourseController:Controller

    {
        private readonly IStudentRepository _repo;
        public CourseController(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _repo.Getcws();
            return View(res);
        }
    }
}
