namespace Chirper.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class ChirperDbContext : IdentityDbContext<User>, IChirperDbContext
    {
        public ChirperDbContext()
                        : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Chirp> Chirps { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public static ChirperDbContext Create()
        {
            return new ChirperDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
