namespace MusicStore.Services.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;
    using MusicStore.Models;

    public class ProducerDataModel
    {
        [Required]
        [MinLength(ValidationConstants.MinProducerName)]
        [MaxLength(ValidationConstants.MaxProducerName)]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}