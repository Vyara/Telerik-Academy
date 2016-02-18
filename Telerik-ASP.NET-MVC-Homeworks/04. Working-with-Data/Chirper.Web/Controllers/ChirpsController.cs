namespace Chirper.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Models;
    using AutoMapper.QueryableExtensions;
    using Chirper.Data.Services.Contracts;
    using Ninject;


    public class ChirpsController : Controller
    {
        [Inject]
        public IChirpService ChirpService { get; set; }

        [HttpGet]
        public ActionResult All()
        {
            var chirps = this.ChirpService.GetAll().ProjectTo<ChirpViewModel>().ToList();

            return this.View(chirps);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var chirp = this.ChirpService.GetById(int.Parse(id));

            return this.View(chirp);
        }
    }
}