namespace MusicStore.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxGenreName)]
        public string Name { get; set; }
    }
}
