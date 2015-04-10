using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Models.Tables;

namespace MovieCatalog.Models.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetById(int id);
        void Delete(int id);
        void Add(Movie movie);
        void Edit(Movie movie);
    }
}
