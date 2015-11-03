namespace StudentSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CourseDataModel
    {
        public string CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}