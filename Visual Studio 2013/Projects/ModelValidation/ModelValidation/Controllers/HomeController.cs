using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ViewResult MakeBooking()
        {
            return View(new Appointment { Date = DateTime.Now});
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            // Statements to store new appointment in a repository project would go here in a real project

            if (ModelState.IsValid)
            {
                return View("Completed", appt);
            }
            return View();
        }


	}
}