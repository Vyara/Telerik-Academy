namespace LibrarySystem.Web.Models
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class BookIndexModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string CategoryName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Book, BookGridModel>("CategoryName")
    .ForMember(b => b.CategoryName, opts => opts.MapFrom(src => src.Category.Name));
        }
    }
}