namespace Movies.Data.Services
{
    using System.Linq;
    using Models;
    using Contracts;
    using Repositories;

    public class MoviesService : IMoviesService
    {
        private IRepository<Movie> movies;

        public MoviesService(IRepository<Movie> movies)
        {
            this.movies = movies;
        }

        public void Create(Movie movie)
        {
            this.movies.Add(movie);
            this.movies.SaveChanges();
        }

        public IQueryable<Movie> GetAll()
        {
            return this.movies.All();
        }

        public Movie GetById(int id)
        {
            return this.movies.GetById(id);
        }

        public void Update(Movie movie)
        {
            this.movies.Update(movie);
            this.movies.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            this.movies.Delete(movie);
            this.movies.SaveChanges();
        }
    }
}
