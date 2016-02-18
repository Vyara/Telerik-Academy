namespace Movies.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Actor
    {
        private ICollection<Movie> movies;

        public Actor()
        {
            this.movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Range(1, 130)]
        public int Age { get; set; }

        public virtual ICollection<Movie> Movies
        {
            get { return this.movies; }

            set { this.movies = value; }
        }
    }
}
