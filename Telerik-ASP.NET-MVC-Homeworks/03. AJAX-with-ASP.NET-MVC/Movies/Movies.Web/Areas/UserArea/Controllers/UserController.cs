namespace Movies.Web.Areas.UserArea.Controllers
{
    using System.Web.Mvc;

    using Data.Models;
    using Data.Services.Contracts;
    using Ninject;
    using Microsoft.AspNet.Identity;
    public class UserController : Controller
    {
        [Inject]
        public IMoviesService CatService { get; set; }

        // GET: UserArea/User
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Movie movie)
        {
            var currentUserId = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                this.CatService.Create(movie);
            }

            return View();
        }
    }
}