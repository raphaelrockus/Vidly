using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
                var movie = new Movie() { Name = "Shrek!" };
                var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

                var viewModel = new RandomMovieViewModel
                {
                    Movie = movie,
                    Customers = customers
                };

                return View(viewModel);
            }
        }
 }

    //Before exercice
    /*public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //parameters are binded by default
        //but we need to consider the default route
        //and name the parameters accordingly if we want it to work
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex, sortBy));
        //}

        //Attribute Routing
        //For constraints we use ':' and regex for regular expressions
        //We can add many more constraints with another ':'
        //For the complete list of constraints
        //ASP.NET MVC Attribute Route Constraints
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
    }*/
