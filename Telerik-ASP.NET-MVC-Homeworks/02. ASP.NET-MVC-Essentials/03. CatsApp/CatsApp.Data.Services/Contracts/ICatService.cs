namespace CatsApp.Data.Services.Contracts
{
    using System.Linq;
    using Models;


    public interface ICatService
    {
        IQueryable<Cat> GetAll();

        Cat GetById(int id);

        void Create(Cat cat, string userId);
    }
}
