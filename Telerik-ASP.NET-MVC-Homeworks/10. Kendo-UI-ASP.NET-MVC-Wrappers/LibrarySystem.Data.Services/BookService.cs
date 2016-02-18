namespace LibrarySystem.Data.Services
{
    using System.Linq;
    using Models;
    using Contracts;
    using Repositories;

    public class BookService : IBookService
    {
        private IRepository<Book> books;

        public BookService(IRepository<Book> books)
        {
            this.books = books;
        }

        public void Create(Book book)
        {
            this.books.Add(book);
            this.books.SaveChanges();
        }

        public IQueryable<Book> GetAll()
        {
            return this.books.All();
        }

        public Book GetById(int id)
        {
            return this.books.GetById(id);
        }

        public void Update(Book book)
        {
            this.books.Update(book);
            this.books.SaveChanges();
        }

        public void Delete(Book book)
        {
            this.books.Delete(book);
            this.books.SaveChanges();
        }

    }
}
