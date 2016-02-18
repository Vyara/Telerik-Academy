namespace Chirper.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class Chirp
    {
        private ICollection<Tag> tags;

        public Chirp()
        {
            this.tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a message, to post a tweet")]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "Message length must be between 5 and 200 symbols")]
        public string Message { get; set; }


        [Required]
        public string CreatorId { get; set; }


        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Tag> Tags
        {
            get { return this.tags; }

            set { this.tags = value; }
        }
    }
}
