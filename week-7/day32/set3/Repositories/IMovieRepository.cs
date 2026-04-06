using Mov.Models;

namespace Mov.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie GetById(int id);
        void Add(Movie m);
        void Update(Movie m);
        void Delete(int id);
        void Save();
    }
}
