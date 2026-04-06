using Mov.Repositories;
using Mov.Models
namespace Mov.Services
{
    public class MovieServices :IMovieServices
    {
        private readonly IMovieRepository _repo;
        public MovieServices(IMovieRepository repo)
        {
            _repo = repo;
        }
        public List<Movie> GetMovies()
        {
            return _repo.GetAll();
        }
        public Movie GetMovie(int id)
        {
            return _repo.GetById(id);
        }
        public void CreateMovie(Movie m)
        {
            _repo.Add(m);
            _repo.Save();
        }
        public void EditMovie(Movie m)
        {
            _repo.Update(m);
            _repo.Save();
        }
        public void RemoveMovie(int id)
        {
            _repo.Delete(id);
            _repo.Save();
        }
            
    }
}
