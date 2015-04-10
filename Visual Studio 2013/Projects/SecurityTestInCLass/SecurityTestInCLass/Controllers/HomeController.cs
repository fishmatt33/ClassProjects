using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SecurityTestInCLass.Models;

namespace SecurityTestInCLass.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult ShowUserInformation()
        {
            var appContext = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(appContext);
            var userMgr = new UserManager<ApplicationUser>(userStore);
            var user = userMgr.FindById(User.Identity.GetUserId());

            return View(user);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AdminOnlyPage()
        {
            return View();
        }


    }
}