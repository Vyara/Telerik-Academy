namespace MusicStore.Services.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Common.Constants;
    using Data.Repositories;
    using Models;
    using MusicStore.Models;

    [EnableCors("*", "*", "*")]
    public class ProducersController : ApiController
    {
        private readonly IMusicStoreData data;

        public ProducersController(IMusicStoreData data)
        {
            this.data = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.data.Producers.All());
        }

        public IHttpActionResult Get(int id)
        {
            var producer = this.data.Producers.Find(id);

            if (producer == null)
            {
                return this.BadRequest(GlobalContants.ProducerNotFoundMessage);
            }

            return this.Ok(producer);
        }

        public IHttpActionResult Post([FromBody]ProducerDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var producer = new Producer
            {
                Name = model.Name
            };

            this.data.Producers.Add(producer);
            this.data.Savechanges();

            return this.Created(this.Url.ToString(), producer);
        }

        public IHttpActionResult Put(int id, [FromBody]ProducerDataModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var producer = this.data.Producers.Find(id);

            if (producer == null)
            {
                return this.BadRequest(GlobalContants.ProducerNotFoundMessage);
            }

            producer.Name = model.Name;
            this.data.Producers.Update(producer);
            this.data.Savechanges();

            return this.Ok(producer);
        }

        public IHttpActionResult Delete(int id)
        {
            var artist = this.data.Producers.GetById(id);

            if (artist == null)
            {
                return this.BadRequest(GlobalContants.InvalidIdMessage);
            }

            this.data.Producers.Delete(id);
            this.data.Producers.SaveChanges();
            return this.Ok();
        }
    }
}