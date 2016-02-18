namespace CatsApp.Data.Services
{
    using System.Linq;
    using Models;
    using Contracts;
    using Repositories;

    public class CatService : ICatService
    {
        private IRepository<Cat> cats;

        public CatService(IRepository<Cat> cats)
        {
            this.cats = cats;
        }

        public void Create(Cat cat, string userId)
        {
            cat.OwnerId = userId;
            this.cats.Add(cat);
            this.cats.SaveChanges();
        }

        public IQueryable<Cat> GetAll()
        {
            return this.cats.All();
        }

        public Cat GetById(int id)
        {
            return this.cats.GetById(id);
        }

    }
}
