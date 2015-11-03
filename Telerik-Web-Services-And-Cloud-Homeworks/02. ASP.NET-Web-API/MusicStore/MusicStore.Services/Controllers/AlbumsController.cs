namespace MusicStore.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Helpers;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class AlbumsController : ApiController
    {
        private readonly IMusicStoreData data;

        public AlbumsController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Albums.All().Select(al =>
           new
           {
               Id = al.Id,
               Title = al.Title,
               Year = al.Year,
               Producer = al.Producer,
               Artists = al.Artists.Select(ar =>
               new
               {
                   Name = ar.Name,
                   DateOfBirth = ar.DateOfBirth,
                   Country = ar.Country
               }),
               Songs = al.Songs
           }));
        }

        public IHttpActionResult Get(int id)
        {
            var album = this.data.Albums.Find(id);

            if (album == null)
            {
                return this.BadRequest(GlobalContants.AlbumNotFoundMessage);
            }

            return this.Ok(new
            {
                Title = album.Title,
                Year = album.Year,
                Producer = album.Producer,
                Artists = album.Artists.Select(ar =>
                new
                {
                    Name = ar.Name,
                    ateOfBirth = ar.DateOfBirth,
                    Country = ar.Country
                }),
                Songs = album.Songs
            });
        }

        public IHttpActionResult Post([FromBody]AlbumDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (this.data.Producers.Find(model.ProducerId) == null)
            {
                return this.BadRequest(GlobalContants.ProducerNotFoundMessage);
            }

            var album = new Album
            {
                Title = model.Title,
                ProducerId = model.ProducerId,
                Year = model.Year
            };

            if (AlbumControllerHelpers.AddArtistsToAlbum(model.ArtistIds, album, this.data) == null || AlbumControllerHelpers.AddSongsToAlbum(model.SongIds, album, this.data) == null)
            {
                return this.BadRequest(GlobalContants.SongOrArtistNotFoundMessage);
            }

            this.data.Albums.Add(album);
            this.data.Savechanges();

            return this.Created(this.Url.ToString(), album);
        }

        public IHttpActionResult Put(int id, [FromBody]AlbumDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var album = this.data.Albums.Find(id);

            if (album == null)
            {
                return this.BadRequest(GlobalContants.AlbumNotFoundMessage);
            }

            if (this.data.Producers.Find(model.ProducerId) == null)
            {
                return this.BadRequest(GlobalContants.ProducerNotFoundMessage);
            }

            album.Title = model.Title;
            album.Year = model.Year;
            album.ProducerId = model.ProducerId;

            if (AlbumControllerHelpers.AddArtistsToAlbum(model.ArtistIds, album, this.data) == null || AlbumControllerHelpers.AddSongsToAlbum(model.SongIds, album, this.data) == null)
            {
                return this.BadRequest(GlobalContants.SongOrArtistNotFoundMessage);
            }

            this.data.Albums.Update(album);
            this.data.Savechanges();

            return this.Ok(album);
        }

        public IHttpActionResult Delete(int id)
        {
            var album = this.data.Albums.GetById(id);

            if (album == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Albums.Delete(id);
            this.data.Albums.SaveChanges();
            return this.Ok();
        }
    }
}