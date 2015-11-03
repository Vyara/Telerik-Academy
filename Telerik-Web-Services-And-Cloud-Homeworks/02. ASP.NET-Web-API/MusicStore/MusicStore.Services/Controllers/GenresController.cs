namespace MusicStore.Services.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class GenresController : ApiController
    {
        private readonly IMusicStoreData data;

        public GenresController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Genres.All());
        }

        public IHttpActionResult Get(int id)
        {
            var genre = this.data.Genres.Find(id);

            if (genre == null)
            {
                return this.BadRequest(GlobalContants.GenreNotFoundMessage);
            }

            return this.Ok(genre);
        }

        public IHttpActionResult Post([FromBody]GenreDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var genre = new Genre
            {
                Name = model.Name
            };

            this.data.Genres.Add(genre);
            this.data.Savechanges();

            return this.Created(this.Url.ToString(), genre);
        }

        public IHttpActionResult Put(int id, [FromBody]GenreDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var genre = this.data.Genres.Find(id);

            if (genre == null)
            {
                return this.BadRequest(GlobalContants.GenreNotFoundMessage);
            }

            genre.Name = model.Name;
            this.data.Genres.Update(genre);
            this.data.Savechanges();

            return this.Ok(genre);
        }

        public IHttpActionResult Delete(int id)
        {
            var genre = this.data.Genres.GetById(id);

            if (genre == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Genres.Delete(id);
            this.data.Genres.SaveChanges();
            return this.Ok();
        }
    }
}