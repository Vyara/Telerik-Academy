namespace StudentSystem.Web.Models
{
    using System;

    public class TestDataModel
    {
        public int Id { get; set; }

        public virtual Guid CourseId { get; set; }
    }
}