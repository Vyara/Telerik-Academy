namespace CatsApp.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class CatsAppDbContext : IdentityDbContext<User>, ICatsAppDbContext
    {
        public CatsAppDbContext()
                        : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Cat> Cats { get; set; }

        public static CatsAppDbContext Create()
        {
            return new CatsAppDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
