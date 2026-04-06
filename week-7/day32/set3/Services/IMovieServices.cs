using Mov.Models;
namespace Mov.Services
{
    public interface IMovieServices
    {
        List<Movie> GetMovies();
        Movie GetMovie(int id);
        void CreateMovie(Movie m);
        void EditMovie(Movie m);
        void RemoveMovie(int id);
    }
}
