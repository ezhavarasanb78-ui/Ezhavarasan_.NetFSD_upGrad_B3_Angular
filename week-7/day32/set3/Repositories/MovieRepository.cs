using Mov.Data;
using Mov.Models;

namespace Mov.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }
        public Movie GetById(int id)
        {
            return _context.Movies.Find(id);
        }
        public void Add(Movie m)
        {
            _context.Movies.Add(m);
        }
        public void Update(Movie m)
        {
            _context.Movies.Update(m);
        }
        public void Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if(movie !=null)
            {
                _context.Movies.Remove(movie);
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
