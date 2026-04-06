using Microsoft.AspNetCore.Mvc;
using.Mov.Models;
using Mov.Services;
namespace Mov.Controllers
{
    public class MoviesController:Controller 
    {
        private readonly IMovieServices _service;
        public MoviesController(IMovieServices service)
        {
            _service = service;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            if(ModelState.IsValid)
            {
                _service.CreateMovie(m);
                return RedirectToAction("Index");
            }
            return View(m);
        }
        public IActionResult Index()
        {
            var movie = _service.GetMovies();
            return View(movie);
        }
        public IActionResult Details(int id)
        {
            var movie = _service.GetMovie(id);
            if(movie==null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult Edit()
        {
            var movie = _service.GetMovie(int id);
            return View(movie);

        }
        [HttpPost]
        public IActionResult Edit(Movies m )
        {
            _service.EditMovie(m);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var movie = _service.GetMovie(id);
            return View(movie);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult Deleteconfirmed(int id)
        {
            _service.RemoveMovie(id);
            return RedirectToAction("Index");
        }
    }
}
