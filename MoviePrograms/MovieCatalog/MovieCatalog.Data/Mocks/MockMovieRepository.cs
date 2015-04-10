using System;
using System.Collections.Generic;
using System.Linq;
using MovieCatalog.Models.Interfaces;
using MovieCatalog.Models.Tables;

namespace MovieCatalog.Data.Mocks
{
    public class MockMovieRepository : IMovieRepository
    {
        private static List<Movie> _allMovies;
 
        static MockMovieRepository()
        {
            _allMovies = new List<Movie>()
            {
                new Movie() { MovieID = 1, Rating = "G", ReleaseDate = new DateTime(1997, 1, 1), RunTime = 86, Title="Ghostbusters"},
                new Movie() { MovieID = 2, Rating = "G", ReleaseDate = new DateTime(2000, 1, 1), RunTime = 93, Title="The Lion King"},
            };
        }

        public List<Movie> GetAllMovies()
        {
            return _allMovies;
        }

        public void Delete(int id)
        {
            _allMovies.RemoveAll(m => m.MovieID == id);
        }

        public void Add(Movie movie)
        {
            movie.MovieID = _allMovies.Max(m => m.MovieID) + 1;
            _allMovies.Add(movie);
        }

        public void Edit(Movie movie)
        {
            _allMovies.RemoveAll(m => m.MovieID == movie.MovieID);
            _allMovies.Add(movie);
        }


        public Movie GetById(int id)
        {
            return _allMovies.FirstOrDefault(m => m.MovieID == id);
        }
    }
}
