namespace DataBaseCounter
{
    using System.Data.Entity;

    public class CounterContext : DbContext
    {
        public CounterContext()
            : base("CounterDb")
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
    }

    public class Visitor
    {
        public int Id { get; set; }

        public int Count { get; set; }
    }
}