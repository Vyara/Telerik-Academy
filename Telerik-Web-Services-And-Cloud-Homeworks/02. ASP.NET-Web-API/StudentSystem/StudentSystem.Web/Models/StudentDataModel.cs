namespace StudentSystem.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class StudentDataModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}