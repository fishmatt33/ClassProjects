using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using DvdLibrary.UI.Models;

namespace DvdLibrary.UI.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
             var database = new FakeDatabase();

            var movies = database.GetAll();

            return View(movies);
        }

        public ActionResult Add()
        {
            var model = new MovieProperties();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddMovie(MovieProperties newMovie)
        {
            if (ModelState.IsValid)
            {
                var database = new FakeDatabase();
                database.Add(newMovie);
                return RedirectToAction("Index");
            }
            return View("Add", newMovie);
        }

        public ActionResult Edit(int id)
        {
            var database = new FakeDatabase();
            var movies = database.GetById(id);

            return View(movies);
        }

        [HttpPost]
        public ActionResult EditMovie(MovieProperties newMovie)
        {
            
            if (ModelState.IsValid)
            {
                var database = new FakeDatabase();
                database.Edit(newMovie);
                return RedirectToAction("Index");
            }
            return View("Edit", newMovie);
        }

        [HttpPost]
        public ActionResult DeleteMovie()
        {
            int movieId = int.Parse(Request.Form["MovieId"]);

            var database = new FakeDatabase();
            database.Delete(movieId);

            var movies = database.GetAll();
            return View("Index", movies);
        }

        public ActionResult Details(int id)
        {
            var database = new FakeDatabase();
            MovieProperties movie = database.GetById(id);
            return View("Details", movie);
        }

        [HttpPost]
        public ActionResult SearchResults(string searchBy, string searchType)
        {
            var database = new FakeDatabase();
            IEnumerable<MovieProperties> results;

            if (searchType == "Title")
            {
                results = database.GetAll().Where(m => m.Title.IndexOf(searchBy, StringComparison.CurrentCultureIgnoreCase) > -1);
                return View("SearchResults", results);
            }
            if (searchType == "Director")
            {
                results = database.GetAll().Where(m => m.Director.IndexOf(searchBy, StringComparison.CurrentCultureIgnoreCase) > -1);
                return View("SearchResults", results);
            }
            if (searchType == "Actor")
            {
                results = database.GetAll().Where(m => m.Actor.IndexOf(searchBy, StringComparison.CurrentCultureIgnoreCase) > -1);
                return View("SearchResults", results);
            }
            
            return View("Index");
        }

        //[HttpPost]
        //public ActionResult Add(MovieProperties newMovie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = new FakeDatabase();
        //        database.Add(newMovie);
        //        var movies = database.GetAll();
        //        return View("Index", movies);
        //    }
        //    return View("Add", newMovie);
        //}
	}
}