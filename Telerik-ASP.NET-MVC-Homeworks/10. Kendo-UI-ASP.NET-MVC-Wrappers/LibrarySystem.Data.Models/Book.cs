namespace LibrarySystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book
    {
        [Key]
        public virtual int Id { get; set; }

        [Required]
        public virtual string Title { get; set; }

        [Required]
        public virtual string Author { get; set; }

        public virtual string ISBN { get; set; }

        public virtual string Website { get; set; }

        public virtual string Description { get; set; }

        public int CategoryId { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}