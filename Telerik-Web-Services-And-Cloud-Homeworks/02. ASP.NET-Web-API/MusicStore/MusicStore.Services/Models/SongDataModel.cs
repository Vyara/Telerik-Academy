namespace MusicStore.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class SongDataModel
    {
        [Required]
        [MinLength(ValidationConstants.MinSongTitle)]
        [MaxLength(ValidationConstants.MaxSongTitle)]
        public string Title { get; set; }

        [Required]
        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        public int AlbumId { get; set; }
    }
}