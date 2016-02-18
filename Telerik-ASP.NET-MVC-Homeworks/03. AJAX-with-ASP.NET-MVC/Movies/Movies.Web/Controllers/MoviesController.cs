using System.Net;

namespace Movies.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Data.Services.Contracts;
    using Models;
    using Ninject;

    public class MoviesController : Controller
    {
        [Inject]
        public IMoviesService MoviesService { get; set; }

        [HttpGet]
        public ActionResult All()
        {
            var movies = this.MoviesService.GetAll().ProjectTo<MovieViewModel>().ToList();

            return this.View(movies);
        }

        [HttpGet]
        public ActionResult Details(string id)
        {
            var movie = this.MoviesService.GetById(int.Parse(id));

            return this.View(movie);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Create");
            }

            this.MoviesService.Create(movie);
            return RedirectToAction("All");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var movie = this.MoviesService.GetById(id);

            return PartialView("_Edit", movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MovieDetailedViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Edit");
            }

            var movie = MoviesService.GetById(model.Id);
            movie.Title = model.Title;
            movie.Studio = model.Studio;
            movie.StudioId = model.Studio.Id;
            movie.ImageUrl = model.ImageUrl;
            movie.LeadingFemale = model.LeadingFemale;
            movie.LeadingFemaleId = model.LeadingFemale.Id;
            movie.LeadingMale = model.LeadingMale;
            movie.LeadingMaleId = model.LeadingMale.Id;
            movie.Director = model.Director;
            movie.Year = model.Year;

            this.MoviesService.Update(movie);
            return RedirectToAction("Details", movie);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            var movie = this.MoviesService.GetById(id);

            return PartialView("_Delete", movie);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Delete");
            }

            this.MoviesService.Delete(movie);
            return RedirectToAction("All");
        }
    }
}