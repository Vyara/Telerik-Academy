namespace MusicStore.Services.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class CountryDataModel
    {
        [Required]
        [MinLength(ValidationConstants.MinCountryName)]
        [MaxLength(ValidationConstants.MaxCountryName)]
        public string Name { get; set; }
    }
}