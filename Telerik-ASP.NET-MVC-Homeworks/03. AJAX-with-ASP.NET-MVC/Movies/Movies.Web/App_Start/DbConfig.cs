namespace Movies.Web.App_Start
{
    using Data;
    using System.Data.Entity;
    using Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
            MoviesDbContext.Create().Database.Initialize(true);
        }
    }
}