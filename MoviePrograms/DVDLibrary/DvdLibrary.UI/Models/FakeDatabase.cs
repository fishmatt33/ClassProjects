using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibrary.UI.Models
{
    public class FakeDatabase
    {
        private static List<MovieProperties> _movies = new List<MovieProperties>();

        static FakeDatabase()
        {
            MovieProperties test = new MovieProperties();
            test.MovieId = int.Parse("1");
            test.Title = "Seven Samurai";
            test.Director = "Akira Kurosawa";
            test.Year = int.Parse("1954");
            test.Rating = "NR";
            test.Runtime = int.Parse("207");
            test.Actor = "Toshiro Mifune, Takeshi Shimura, Keiko Tsushima";
            test.Trailer = "https://www.youtube.com/watch?v=MwvpUtc1hBU";

            _movies.Add(test);

            MovieProperties test2 = new MovieProperties();
            test2.MovieId = int.Parse("2");
            test2.Title = "The Hidden Fortress";
            test2.Director = "Akira Kurosawa";
            test2.Year = int.Parse("1958");
            test2.Rating = "NR";
            test2.Runtime = int.Parse("126");
            test2.Actor = "Toshiro Mifune, Misa Uehara, Minoru Chiaki";
            
            _movies.Add(test2);

            MovieProperties test3 = new MovieProperties();

            test3.MovieId = int.Parse("3");
            test3.Title = "In the Mood for Love";
            test3.Director = "Wong Kar-Wai";
            test3.Year = int.Parse("2000");
            test3.Rating = "PG";
            test3.Runtime = int.Parse("98");
            test3.Actor = "Tony Chiu Wai Leung, Maggie Cheung, Ping Lam Siu";

            _movies.Add(test3);
        }
        
        public List<MovieProperties> GetAll()
        {
            return _movies;
        }

        public void Add(MovieProperties movie)
        {
            if (_movies.Any())
                movie.MovieId = _movies.Max(m => m.MovieId) + 1;
            else
                movie.MovieId = 1;

            _movies.Add(movie);
        }

        public void Delete(int id)
        {
            _movies.RemoveAll(m => m.MovieId == id);
        }

        public void Edit(MovieProperties movie)
        {
            Delete(movie.MovieId);
            _movies.Add(movie);
        }

        public MovieProperties GetById(int id)
        {
            return _movies.First(m => m.MovieId == id);
        }
    }
}