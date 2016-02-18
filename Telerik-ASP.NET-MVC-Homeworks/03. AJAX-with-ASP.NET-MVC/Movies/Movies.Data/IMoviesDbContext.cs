namespace Movies.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface IMoviesDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users { get; set; }

        IDbSet<Movie> Movies { get; set; }

        IDbSet<Actor> Actors { get; set; }

        IDbSet<Actress> Actresses { get; set; }

        IDbSet<Studio> Studios { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    }
}
