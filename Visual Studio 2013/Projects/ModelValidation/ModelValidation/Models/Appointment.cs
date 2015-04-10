using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models
{
    public class Appointment
    {
        [Required(ErrorMessage = "Please enter a name")]
        
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Please enter a date in the future")]
        public DateTime Date { get; set; }

        [MustBeTrue( ErrorMessage = "You must accept the terms")]
        public bool TermsAccepted { get; set; }
    }
}