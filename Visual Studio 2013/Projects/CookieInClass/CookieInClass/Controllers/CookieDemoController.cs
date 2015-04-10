using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieInClass.Controllers
{
    public class CookieDemoController : Controller
    {
        // GET: CookieDemo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCookie(string cookieName, string cookieValue)
        {
            HttpCookie cookie = new HttpCookie(cookieName, cookieValue);

            this.Response.Cookies.Add(cookie);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteCookie(string id)
        {
            HttpCookie cookie = new HttpCookie(id);
            cookie.Expires = DateTime.Now.AddDays(-1);

            this.Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }
    }
}