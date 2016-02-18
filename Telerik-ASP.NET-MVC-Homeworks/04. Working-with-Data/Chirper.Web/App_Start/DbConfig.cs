namespace Chirper.Web.App_Start
{
    using Data;
    using System.Data.Entity;
    using Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChirperDbContext, Configuration>());
            ChirperDbContext.Create().Database.Initialize(true);
        }
    }
}