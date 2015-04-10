using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Models.Tables
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int? RunTime { get; set; }
        public string Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
