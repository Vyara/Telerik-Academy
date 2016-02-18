namespace Movies.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class MoviesDbContext : IdentityDbContext<User>, IMoviesDbContext
    {
        public MoviesDbContext()
                        : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Movie> Movies { get; set; }

        public IDbSet<Actor> Actors { get; set; }

        public IDbSet<Actress> Actresses { get; set; }

        public IDbSet<Studio> Studios { get; set; }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
