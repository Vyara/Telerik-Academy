namespace StudentSystem.Web.Controllers
{
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Data;
    using Models;

    public class HomeworksController : ApiController
    {
        private IStudentSystemData data;

        public HomeworksController(IStudentSystemData studentSystemData)
        {
            this.data = studentSystemData;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            return this.Ok(this.data.Homeworks.All().ProjectTo<HomeworkDataModel>());
        }
    }
}