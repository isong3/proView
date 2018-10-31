using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proView.Models;
using proView.ViewModels;

namespace proView.Controllers
{
	public class MoviesController : Controller
	{
		public ViewResult Index()
		{
			var movies = GetMovies();

			return View(movies);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie { Id = 1, Name = "Shrek" },
				new Movie { Id = 2, Name = "Wall-e" }
			};
		}

		// GET: Movies/Random
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek" };

			//return View(movie);
			//return Content("Hello World!");
			//return HttpNotFound();
			//return new EmptyResult();
			//return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

			//ViewData["Movie"] = movie;
			//ViewBag.RandomMovie = movie;
			//return View();

			//var viewResult = new ViewResult();
			//viewResult.ViewData.Model

			var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1"},
				new Customer { Name = "Customer 2"}
			};


			var viewMode = new RandomMovieViewModel
			{
				Movie = movie,
				Customers =  customers
			};

			return View(viewMode);
		}

		/*
		public ActionResult Edit(int id)
		{
			return Content("id=" + id);
		}

		public ActionResult Index(int? pageIndex, string sortBy)
		{
			if (!pageIndex.HasValue)
				pageIndex = 1;

			if (String.IsNullOrWhiteSpace(sortBy))
				sortBy = "Name";

			return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
		}


		[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
		public ActionResult ByReleaseYear(int year, int month)
		{
			return Content(year + "/" + month);
		}
		*/
	}
}