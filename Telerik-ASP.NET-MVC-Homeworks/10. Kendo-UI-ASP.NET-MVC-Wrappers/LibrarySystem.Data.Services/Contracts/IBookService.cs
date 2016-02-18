namespace LibrarySystem.Data.Services.Contracts
{
    using System.Linq;
    using Models;


    public interface IBookService
    {
        IQueryable<Book> GetAll();

        Book GetById(int id);

        void Create(Book book);

        void Update(Book book);

        void Delete(Book book);

    }
}
