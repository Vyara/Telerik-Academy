namespace MusicStore.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;
    using MusicStore.Models;

    public class AlbumDataModel
    {
        [Required]
        [MaxLength(ValidationConstants.MaxAlbumTitle)]
        public string Title { get; set; }

        [Required]
        public DateTime? Year { get; set; }

        [Required]
        public int ProducerId { get; set; }

        [Required]
        public int[] SongIds { get; set; }

        [Required]
        public int[] ArtistIds { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}