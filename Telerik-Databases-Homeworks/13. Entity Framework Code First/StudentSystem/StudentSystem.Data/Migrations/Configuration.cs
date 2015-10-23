namespace StudentSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<StudentStystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentStystemDbContext context)
        {
            context.Courses.AddOrUpdate(
                          c => c.Name,
                          new Course { Name = "High-Quality Code 2015" },
                          new Course { Name = "Databases 2015" },
                          new Course { Name = "Communicating with Clients 2015" },
                          new Course { Name = "JavaScript Applications 2015" }
                        );

            context.Students.AddOrUpdate(
                s => new { s.FirstName, s.LastName },
                new Student { FirstName = "Niki", LastName = "Kostov" },
                new Student { FirstName = "Ivaylo", LastName = "Kenov" },
                new Student { FirstName = "Doncho", LastName = "Minkov" },
                new Student { FirstName = "Evlogi", LastName = "Hristov" }
            );
        }
    }
}
