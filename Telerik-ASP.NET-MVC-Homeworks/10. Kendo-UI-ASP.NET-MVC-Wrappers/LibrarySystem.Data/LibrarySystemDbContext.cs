namespace LibrarySystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class LibrarySystemDbContext : IdentityDbContext<User>, ILibrarySystemDbContext
    {
        public LibrarySystemDbContext()
                        : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Book> Books { get; set; }

       public IDbSet<Category> Categories { get; set; }

        public static LibrarySystemDbContext Create()
        {
            return new LibrarySystemDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
