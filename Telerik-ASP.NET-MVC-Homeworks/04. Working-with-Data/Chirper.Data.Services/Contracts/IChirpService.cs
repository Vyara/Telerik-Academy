namespace Chirper.Data.Services.Contracts
{
    using System.Linq;
    using Models;


    public interface IChirpService
    {
        IQueryable<Chirp> GetTop(int count);

        IQueryable<Chirp> GetByCreatorId(string id);

        IQueryable<Chirp> GetAll();

        Chirp GetById(int id);

        IQueryable<Chirp> GetByTagName(Tag tag);

        void UpdateById(int id, Chirp updateChirp);

        void DeleteById(int id);

        void Create(Chirp chirp);
    }
}
