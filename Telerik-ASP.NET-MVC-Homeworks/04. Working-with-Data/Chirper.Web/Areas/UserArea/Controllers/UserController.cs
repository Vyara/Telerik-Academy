using Microsoft.AspNet.Identity.EntityFramework;

namespace Chirper.Web.Areas.UserArea.Controllers
{
    using System.Web.Mvc;

    using Data.Models;
    using Ninject;
    using Microsoft.AspNet.Identity;
    public class UserController : Controller
    {
        [Inject]

        // GET: UserArea/User
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(Cat cat)
        //{
        //    var currentUserId = User.Identity.GetUserId();
        //    if (ModelState.IsValid)
        //    {
        //        this.CatService.Create(cat, currentUserId);
        //    }

        //    return View();
        //}
    }
}