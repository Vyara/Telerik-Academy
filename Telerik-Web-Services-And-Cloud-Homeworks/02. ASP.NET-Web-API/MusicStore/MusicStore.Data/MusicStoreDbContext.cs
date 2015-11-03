namespace MusicStore.Data
{
    using System.Data.Entity;
    using Models;

  public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext()
            : base("MusicStoreDb")
        {
        }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Country> Country { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public virtual IDbSet<Genre> Genres { get; set; }

        public virtual IDbSet<Producer> Producers { get; set; }
    }
}
