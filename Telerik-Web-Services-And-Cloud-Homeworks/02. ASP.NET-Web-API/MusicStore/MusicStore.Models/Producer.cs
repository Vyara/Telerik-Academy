namespace MusicStore.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class Producer
    {
        private ICollection<Artist> artists;

        public Producer()
        {
            this.artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinProducerName)]
        [MaxLength(ValidationConstants.MaxProducerName)]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists
        {
            get { return this.artists; }

            set { this.artists = value; }
        }
    }
}
