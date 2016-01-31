namespace Todos.Data
{
    using System.Data.Entity;
    using Todos.Data.Migrations;
    using Todos.Data.Models;

    public class TodosDbContext : DbContext
    {
        public TodosDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TodosDbContext, Configuration>());
        }

        public IDbSet<Todo> Todos { get; set; }

        public IDbSet<Category> Categories { get; set; }
    }
}