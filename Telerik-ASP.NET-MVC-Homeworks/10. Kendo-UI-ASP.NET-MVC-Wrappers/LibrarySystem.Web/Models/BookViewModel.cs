namespace LibrarySystem.Web.Models
{
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class BookViewModel : IMapFrom<Book>
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }

        public virtual string Author { get; set; }

        public virtual string ISBN { get; set; }

        public virtual string Website { get; set; }

        public virtual string Description { get; set; }

        public Category Category { get; set; }

    }
}