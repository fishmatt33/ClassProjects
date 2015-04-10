using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("ShopSchema", "Shop/{action}",
                new {controller = "Home"});

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}", 
                new {controller = "Home", action = "Index", id = UrlParameter.Optional});

            routes.MapRoute("", "X{controller}/{action}");

        }
    }
}
