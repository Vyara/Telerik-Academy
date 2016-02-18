namespace LibrarySystem.Data.Services.Contracts
{
    using System.Linq;
    using Models;

    public interface ICategoryService
    {
        void Create(Category category);

        IQueryable<Category> GetAll();

        Category GetById(int id);

        Category GetByIName(string name);

        void Update(Category category);

        void Delete(Category category);

    }
}