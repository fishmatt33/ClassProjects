using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCatalog.Models.Interfaces;
using MovieCatalog.Models.Tables;

namespace MovieCatalog.Data.SqlServer
{
    public class SqlMovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "MovieGetAll";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var movie = new Movie();

                        movie.MovieID = (int)dr["MovieID"];
                        movie.Title = dr["Title"].ToString();

                        if (dr["Runtime"] != DBNull.Value)
                            movie.RunTime = (int)dr["RunTime"];

                        if (dr["Rating"] != DBNull.Value)
                            movie.Rating = dr["Rating"].ToString();

                        if (dr["ReleaseDate"] != DBNull.Value)
                            movie.ReleaseDate = (DateTime)dr["ReleaseDate"];

                        allMovies.Add(movie);
                    }
                }
            }

            return allMovies;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Edit(Movie movie)
        {
            throw new NotImplementedException();
        }


        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
