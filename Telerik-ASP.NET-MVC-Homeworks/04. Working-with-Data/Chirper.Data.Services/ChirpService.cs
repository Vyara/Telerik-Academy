namespace Chirper.Data.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using System.Text;
    using System.Threading.Tasks;
    using Models;
    using Repositories;

    public class ChirpService : IChirpService
    {
        private IRepository<Chirp> chirps;

        public ChirpService(IRepository<Chirp> chirps)
        {
            this.chirps = chirps;
        }

        public void Create(Chirp chirp)
        {
            this.chirps.Add(chirp);
            this.chirps.SaveChanges();
        }

        public void DeleteById(int id)
        {
            this.chirps.Delete(id);
            this.chirps.SaveChanges();
        }

        public IQueryable<Chirp> GetAll()
        {
            return this.chirps.All();
        }

        public IQueryable<Chirp> GetByCreatorId(string id)
        {
            return this.chirps.All().Where(x => x.CreatorId == id);
        }

        public Chirp GetById(int id)
        {
            return this.chirps.GetById(id);
        }

        public IQueryable<Chirp> GetByTagName(Tag tag)
        {
            return this.chirps.All().Where(x => x.Tags.Contains(tag));
        }

        public IQueryable<Chirp> GetTop(int count)
        {
            return this.chirps.All().OrderByDescending(x => x.CreationDate).Take(count);
        }

        public void UpdateById(int id, Chirp updateChirp)
        {
            var chirpToUpdate = this.chirps.GetById(id);
            chirpToUpdate.Message = chirpToUpdate.Message;
            chirpToUpdate.Tags = chirpToUpdate.Tags;

            this.chirps.SaveChanges();

        }
    }
}
