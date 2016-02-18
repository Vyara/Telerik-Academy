namespace CatsApp.Web.Models
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CatViewModel : IMapFrom<Cat>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

    }
}