using Microsoft.AspNetCore.Mvc;
using StudentCourseSystem.Repository;

namespace StudentCourseSystem.Controllers
{
    public class StudentController:Controller
    {
        private readonly IStudentRepository _repo;
        public StudentController(IStudentRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var res = await _repo.Getswc();
            return View(res);
        }
    }
}
