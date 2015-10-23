namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Data;
    using Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentStystemDbContext, Configuration>());

            var con = new StudentStystemDbContext();

            Console.WriteLine("Students: ");
            con.Students
                .Select(s => new { s.FirstName, s.LastName })
                .ToList()
                .ForEach(s => System.Console.WriteLine("* {0} {1}", s.FirstName, s.LastName));
        }
    }
}
