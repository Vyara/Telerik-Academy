namespace MusicStore.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using Common.Constants;
    using MusicStore.Models;

    public class ArtistDataModel
    {
        public static Expression<Func<Artist, ArtistDataModel>> FromModel
        {
            get
            {
                return a => new ArtistDataModel
                {
                    Name = a.Name,
                    DateOfBirth = a.DateOfBirth,
                    CountryId = a.CountryId
                };
            }
        }

        [Required]
        [MinLength(ValidationConstants.MinArtistName)]
        [MaxLength(ValidationConstants.MaxArtistName)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public int CountryId { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}