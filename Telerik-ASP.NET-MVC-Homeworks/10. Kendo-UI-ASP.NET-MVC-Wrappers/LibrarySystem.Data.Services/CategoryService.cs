namespace LibrarySystem.Data.Services
{
    using System.Linq;
    using Models;
    using Contracts;
    using Repositories;

    public class CategoryService : ICategoryService
    {
        private IRepository<Category> categories;
        private IRepository<Book> books;

        public CategoryService(IRepository<Category> categories, IRepository<Book> books)
        {
            this.categories = categories;
            this.books = books;
        }

        public void Create(Category category)
        {
            this.categories.Add(category);
            this.categories.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }

        public Category GetById(int id)
        {
            return this.categories.GetById(id);
        }

        public Category GetByIName(string name)
        {
            return this.categories.All().Where(c => c.Name == name).FirstOrDefault();
        }

        public Category GetByBookId(int id)
        {
            var book = this.books.GetById(id);
            return this.categories.GetById(book.CategoryId);
        }

        public void Update(Category category)
        {
            this.categories.Update(category);
            this.categories.SaveChanges();
        }

        public void Delete(Category category)
        {
            this.categories.Delete(category);
            this.categories.SaveChanges();
        }
    }
}
