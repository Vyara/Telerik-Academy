
namespace StudentSystem.ConsoleClient
{
    using Data;
    using Data.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Startup
    {

       public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentStystemDbContext, Configuration>());

            var studentsContext = new StudentStystemDbContext();

            Console.WriteLine("Students currently in the system: ");
            studentsContext.Students
                .Select(s => new { s.FirstName, s.LastName })
                .ToList()
                .ForEach(s => Console.WriteLine("- {0} {1}", s.FirstName, s.LastName));
        }

    }
}

