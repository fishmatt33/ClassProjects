using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieCatalog.Models.Interfaces;

namespace MovieCatalog.UI.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _movieRepository.GetAllMovies();

            return View(movies);
        }
    }
}