namespace MusicStore.Services.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class CountriesController : ApiController
    {
        private readonly IMusicStoreData data;

        public CountriesController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Countries.All());
        }

        public IHttpActionResult Get(int id)
        {
            var country = this.data.Countries.Find(id);

            if (country == null)
            {
                return this.BadRequest(GlobalContants.CountryNotFoundMessage);
            }

            return this.Ok(country);
        }

        public IHttpActionResult Post([FromBody]CountryDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var country = new Country
            {
                Name = model.Name
            };

            this.data.Countries.Add(country);
            this.data.Savechanges();

            return this.Created(this.Url.ToString(), country);
        }

        public IHttpActionResult Put(int id, [FromBody] CountryDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var country = this.data.Countries.Find(id);

            if (country == null)
            {
                return this.BadRequest(GlobalContants.CountryNotFoundMessage);
            }

            country.Name = model.Name;
            this.data.Countries.Update(country);
            this.data.Savechanges();

            return this.Ok(country);
        }

        public IHttpActionResult Delete(int id)
        {
            var contry = this.data.Countries.GetById(id);

            if (contry == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Countries.Delete(id);
            this.data.Countries.SaveChanges();
            return this.Ok();
        }
    }
}