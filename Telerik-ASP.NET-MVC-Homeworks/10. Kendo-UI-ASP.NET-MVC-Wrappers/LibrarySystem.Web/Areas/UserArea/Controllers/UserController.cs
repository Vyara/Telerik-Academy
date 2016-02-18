using System.Linq;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;

namespace LibrarySystem.Web.Areas.UserArea.Controllers
{
    using System.Web.Mvc;

    using Data.Models;
    using Data.Services.Contracts;
    using Ninject;
    using Models;
    using Kendo.Mvc.UI;
    public class UserController : Controller
    {
        [Inject]
        public IBookService BookService { get; set; }

        [Inject]
        public ICategoryService CategoryService { get; set; }

        // GET: UserArea/User
        public ActionResult Index()
        {
            var books = this.BookService.GetAll().ProjectTo<BookGridModel>().ToList();
            return View(books);
        }


        public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var books = this.BookService.GetAll().ProjectTo<BookGridModel>().ToList();

            foreach (var item in books)
            {
                if (item.Description != null && item.Description.Length > 15)
                {
                    item.Description = item.Description.Substring(0, 15);
                }
            }

            DataSourceResult result = books.ToDataSourceResult(request);

            return Json(result);
        }

        public ActionResult Create([DataSourceRequest]DataSourceRequest request, BookGridModel book)
        {
            if (ModelState.IsValid)
            {

                Book newBook = new Book()
                {
                    Description = book.Description,
                    Author = book.Author,
                    ISBN = book.ISBN,
                    Title = book.Title,
                    Website = book.Website
                };

                this.BookService.Create(newBook);

                book.Id = newBook.Id;
            }

            return Json(new[] { book }.ToDataSourceResult(request, ModelState));
        }


        public ActionResult Edit([DataSourceRequest]DataSourceRequest request, BookGridModel book)
        {
            if (ModelState.IsValid)
            {
                var bookCategory = this.CategoryService.GetByIName(book.CategoryName);
                var bookToUpdate = this.BookService.GetById(book.Id);

                if (bookToUpdate.Category.Name != book.CategoryName)
                {

                    bookToUpdate.Category = bookCategory;
                }

                UpdateBookFields(book, bookToUpdate);

                this.BookService.Update(bookToUpdate);
            }
            return Json(new[] { book }.ToDataSourceResult(request, ModelState));
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(BookViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return PartialView("_Edit");
        //    }

        //    var book = BookService.GetById(model.Id);
        //    book.Title = model.Title;
        //    book.Author = model.Author;
        //    book.CategoryId = model.Category.Id;
        //    book.ISBN = model.ISBN;
        //    book.Description = model.Description;
        //    book.Website = model.Website;
        //    this.BookService.Update(book);
        //    return RedirectToAction("Details", "Books", book);
        //}


        public ActionResult Delete(Book book)
        {
            this.BookService.Delete(book);
            return RedirectToAction("All", "Books");
        }

        private static void UpdateBookFields(BookGridModel book, Book oldBook)
        {
            oldBook.Author = book.Author;
            oldBook.Description = book.Description;
            oldBook.ISBN = book.ISBN;
            oldBook.Title = book.Title;
            oldBook.Website = book.Website;
        }
    }
}