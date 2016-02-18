namespace Movies.Web.Models
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class MovieViewModel : IMapFrom<Movie>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string ImageUrl { get; set; }

    }
}