using Microsoft.AspNetCore.Mvc;
using EF.Models;
using EF.Data;
namespace EF.Controllers
{
    public class MoviesController: Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            _context.Movies.Add(m);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            _context.Movies.Add(m);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            return View(movie);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(Movie m)
        {
            _context.Movies.Remove(m);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Find(id);
            return View(movie);
        }
    }
}
