namespace CatsApp.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Services.Contracts;
    using Models;
    using Ninject;

    public class CatsController : Controller
    {
        [Inject]
        public ICatService CatService { get; set; }

        [HttpGet]
        public ActionResult All()
        {
            var cats = this.CatService.GetAll().ProjectTo<CatViewModel>().ToList();

            return this.View(cats);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var cat = this.CatService.GetById(int.Parse(id));

            return this.View(cat);
        }
    }
}