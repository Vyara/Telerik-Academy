
namespace Movies.Web.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Data.Models;

    public class MovieDetailedViewModel
    {
        public int Id { get; set; }

        [Index("MovieTitleIndex", IsUnique = true)]
        [MaxLength(500)]
        public string Title { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }

        public string ImageUrl { get; set; }

        public  Actor LeadingMale { get; set; }

        public Actress LeadingFemale { get; set; }

        public Studio Studio { get; set; }

    }
}