namespace MusicStore.Services.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class SongsController : ApiController
    {
        private readonly IMusicStoreData data;

        public SongsController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Songs.All());
        }

        public IHttpActionResult Get(int id)
        {
            var song = this.data.Songs.Find(id);

            if (song == null)
            {
                return this.BadRequest(GlobalContants.SongNotFoundMessage);
            }

            return this.Ok(song);
        }

        public IHttpActionResult Post([FromBody]SongDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (this.data.Genres.Find(model.GenreId) == null)
            {
                return this.BadRequest(GlobalContants.GenreNotFoundMessage);
            }

            var song = new Song
            {
                Title = model.Title,
                GenreId = model.GenreId,
            };

            this.data.Songs.Add(song);
            this.data.Savechanges();

            return this.Created(this.Url.ToString(), song);
        }

        public IHttpActionResult Put(int id, [FromBody]SongDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var song = this.data.Songs.Find(id);

            if (song == null)
            {
                return this.BadRequest(GlobalContants.SongNotFoundMessage);
            }

            if (this.data.Genres.Find(model.GenreId) == null)
            {
                return this.BadRequest(GlobalContants.GenreNotFoundMessage);
            }

            song.Title = model.Title;
            song.GenreId = model.GenreId;
            this.data.Songs.Update(song);
            this.data.Savechanges();

            return this.Ok(song);
        }

        public IHttpActionResult Delete(int id)
        {
            var song = this.data.Songs.GetById(id);

            if (song == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Songs.Delete(id);
            this.data.Songs.SaveChanges();
            return this.Ok();
        }
    }
}