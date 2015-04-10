using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DvdLibrary.UI.Models
{
    public class MovieProperties
    {
        public int MovieId { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Please enter a Title greater than 3 characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Please enter a name greater than 3 characters")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a rating")]
        public string Rating { get; set; }

        [Required]
        [Range(1900, 2020, ErrorMessage = "Please select a year between 1900 and 2020")]
        [DataType(DataType.DateTime)]
        public int Year { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter the minutes between 1 and 1000")]
        [DataType(DataType.Duration)]
        public int Runtime { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Actor { get; set; }

        public string Trailer { get; set; }
    }
}