namespace Movies.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Index("MovieTitleIndex", IsUnique = true)]
        [MaxLength(500)]
        public string Title { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }

        public string ImageUrl { get; set; }

        public int LeadingMaleId { get; set; }

        [ForeignKey("LeadingMaleId")]
        public virtual Actor LeadingMale { get; set; }

        public int LeadingFemaleId { get; set; }

        [ForeignKey("LeadingFemaleId")]
        public virtual Actress LeadingFemale { get; set; }

        public int StudioId { get; set; }

        [ForeignKey("StudioId")]
        public virtual Studio Studio { get; set; }

    }
}
