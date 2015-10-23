namespace StudentSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentStystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(StudentStystemDbContext context)
        {
            context.Students.AddOrUpdate(
                s => new { s.FirstName, s.LastName, s.Number },
                new Student { FirstName = "Nikolay", LastName = "Kostov", Number = 2222 },
                new Student { FirstName = "Ivaylo", LastName = "Kenov", Number = 3333 },
                new Student { FirstName = "Doncho", LastName = "Minkov", Number = 4444 },
                new Student { FirstName = "Evlogi", LastName = "Hristov", Number = 5555 });
        }
    }
}
