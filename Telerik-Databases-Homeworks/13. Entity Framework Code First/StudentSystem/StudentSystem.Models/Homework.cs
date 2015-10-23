namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public virtual Student Students { get; set; }

        public int CourseId { get; set; }

        public virtual Course Courses { get; set; }
    }
}
