namespace Movies.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Studio
    {
        private ICollection<Movie> movies;

        public Studio()
        {
            this.movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Movie> Movies
        {
            get { return this.movies; }

            set { this.movies = value; }
        }
    }
}
