namespace MusicStore.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Country
    {
        private ICollection<Artist> artists;

        public Country()
        {
            this.artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinCountryName)]
        [MaxLength(ValidationConstants.MaxCountryName)]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }

            set { this.artists = value; }
        }
    }
}
