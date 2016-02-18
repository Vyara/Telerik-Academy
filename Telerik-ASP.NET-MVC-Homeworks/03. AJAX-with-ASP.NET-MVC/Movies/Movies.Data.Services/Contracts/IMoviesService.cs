namespace Movies.Data.Services.Contracts
{
    using System.Linq;
    using Models;


    public interface IMoviesService
    {
        IQueryable<Movie> GetAll();

        Movie GetById(int id);

        void Create(Movie movie);

        void Update(Movie movie);

        void Delete(Movie movie);
    }
}
