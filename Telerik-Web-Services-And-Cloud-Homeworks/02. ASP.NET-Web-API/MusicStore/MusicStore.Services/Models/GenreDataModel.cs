namespace MusicStore.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class GenreDataModel
    {
        [Required]
        [MaxLength(ValidationConstants.MaxGenreName)]
        public string Name { get; set; }
    }
}