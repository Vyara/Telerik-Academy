namespace LibrarySystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Data.Services.Contracts;
    using Models;
    using Ninject;

    public class BooksController : Controller
    {
        [Inject]
        public IBookService BookService { get; set; }

        [HttpGet]
        public ActionResult All()
        {
            var books = this.BookService.GetAll().ProjectTo<BookIndexModel>().ToList();

            return this.View(books);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var book = this.BookService.GetById(int.Parse(id));

            return this.View(book);
        }

    }
}