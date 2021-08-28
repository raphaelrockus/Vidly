using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Define routes from the more generic to the more specific
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "movies/released/{year}/{month}",
                //this syntax means that this is an anonymous object
                defaults: new {controller = "Movies", action = "ByReleaseDate"},
                //constraint to have the year in four digits and the month with two digits
                //constraints: new { year = @"\d{4}", month = @"\d{2}"}
                //other constraint to limit ourselves to the year 2015 or 2016
                constraints: new { year = @"2015|2016", month = @"\d{2}"}

                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
