namespace StudentSystem.Data
{
    using System.Data.Entity;
    using Models;

    public class StudentStystemDbContext : DbContext
    {
        public StudentStystemDbContext()
            : base("StudentsSystemDb")
        {
        }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Student> Students { get; set; }
    }
}
