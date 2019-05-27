using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = GetMovies().FirstOrDefault();
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Marisol Abduraman"},
                new Customer { Id = 2, Name = "Mickey Mouse"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Index()
        {
            return View(GetMovies());
        }


        //temporary list of values for movies
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!"},
                new Movie { Id = 2, Name = "Wall-e"}
            };
        }

    }
}