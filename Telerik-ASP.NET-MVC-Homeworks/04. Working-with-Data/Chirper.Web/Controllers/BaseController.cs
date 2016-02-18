namespace Chirper.Web.Controllers
{
    using System.Web.Mvc;
    using Chirper.Data.Services.Contracts;
    using Ninject;

    public class BaseController : Controller
    {
        //[Inject]
        //public IChirpService ChirpService { get; set; }
    }
}