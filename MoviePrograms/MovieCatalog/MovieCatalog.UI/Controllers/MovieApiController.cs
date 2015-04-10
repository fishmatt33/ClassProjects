using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieCatalog.Models.Interfaces;
using MovieCatalog.Models.Tables;

namespace MovieCatalog.UI.Controllers
{
    public class MovieApiController : ApiController
    {
        private IMovieRepository _movieRepository;

        public MovieApiController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> Get()
        {
            return _movieRepository.GetAllMovies();
        }

        public Movie Get(int id)
        {
            return _movieRepository.GetById(id);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public HttpStatusCode Put(Movie movie)
        {
            _movieRepository.Edit(movie);
            return HttpStatusCode.OK;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}