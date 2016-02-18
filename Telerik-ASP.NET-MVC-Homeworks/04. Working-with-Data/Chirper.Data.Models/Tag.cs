namespace Chirper.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
        private ICollection<Chirp> chirps;

        public Tag()
        {
            this.chirps = new HashSet<Chirp>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tag must have a name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Tag name must be between 1 and 50 symbols")]
        public string Name { get; set; }

        public virtual ICollection<Chirp> Chirps
        {
            get { return this.chirps; }

            set { this.chirps = value; }
        }

    }
}
