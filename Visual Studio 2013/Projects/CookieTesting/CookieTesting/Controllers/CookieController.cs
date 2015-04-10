using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CookieTesting.Controllers
{
    public class CookieController : Controller
    {
        private const string CookieName = "WebstorageDemoCookie";

        public ActionResult WriteCookie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriteCookie(Cookie theCookie)
        {
            HttpCookie myCookie = CreateCookie();
            myCookie ["Name"] = theCookie.Name;
            myCookie["Value"] = theCookie.Value;

            Response.Cookies.Add(myCookie);
            return RedirectToAction("ReadCookie");
        }

        private HttpCookie CreateCookie()
        {
            HttpCookie cookie;

            if (Request.Cookies[CookieName] == null)
            {
                cookie = new HttpCookie(CookieName);
            }

            else
            {
                cookie = Request.Cookies[CookieName];
            }

            cookie.Expires = DateTime.Now.AddDays(7);
            return cookie;
        }

        public ActionResult ReadCookie()
        {
            Cookie theCookie = new Cookie();
            var cookie = Request.Cookies[CookieName];

            if (cookie != null)
            {
                theCookie.Name = cookie["Name"];
                theCookie.Value = cookie["Value"];
            }
            else
            {
                theCookie.Name = "No Cookie";
            }

            return View(theCookie);
        }
    }
}