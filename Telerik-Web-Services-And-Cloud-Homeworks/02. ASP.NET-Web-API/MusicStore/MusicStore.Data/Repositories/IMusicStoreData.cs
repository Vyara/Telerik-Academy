namespace MusicStore.Data.Repositories
{
    using Models;

    public interface IMusicStoreData
    {
        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Country> Countries { get; }

        IRepository<Genre> Genres { get; }

        IRepository<Producer> Producers { get; }

        IRepository<Song> Songs { get; }

        int Savechanges();
    }
}
