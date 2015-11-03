namespace MusicStore.Services.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class ArtistsController : ApiController
    {
        private readonly IMusicStoreData data;

        public ArtistsController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            var result = this.data.Artists.All();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.data.Artists.Find(id);

            if (result == null)
            {
                return this.BadRequest(GlobalContants.ArtistNotFoundMessage);
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post([FromBody]ArtistDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (this.data.Countries.Find(model.CountryId) == null)
            {
                return this.BadRequest(GlobalContants.CountryNotFoundMessage);
            }

            var artist = new Artist
            {
                Name = model.Name,
                DateOfBirth = model.DateOfBirth,
                CountryId = model.CountryId,
                Albums = model.Albums
            };

            this.data.Artists.Add(artist);
            this.data.Artists.SaveChanges();

            return this.Created(this.Url.ToString(), artist);
        }

        public IHttpActionResult Put(int id, [FromBody]ArtistDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var artist = this.data.Artists.GetById(id);

            if (artist == null)
            {
                return this.BadRequest(GlobalContants.ArtistNotFoundMessage);
            }

            if (this.data.Countries.Find(model.CountryId) == null)
            {
                return this.BadRequest(GlobalContants.CountryNotFoundMessage);
            }

            artist.Name = model.Name;
            artist.CountryId = model.CountryId;
            this.data.Artists.Update(artist);
            this.data.Savechanges();

            return this.Ok(artist);
        }

        public IHttpActionResult Delete(int id)
        {
            var artist = this.data.Artists.GetById(id);

            if (artist == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Artists.Delete(id);
            this.data.Artists.SaveChanges();
            return this.Ok();
        }
    }
}