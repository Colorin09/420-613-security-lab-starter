﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Original Route
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Student",
                url: "students/{id}",
                defaults: new { Controller = "Student", action = "Index" }
                );

            routes.MapRoute(
                name: "404Error",
                url: "{*url}",
                 defaults: new { controller = "Error", action = "NotFound" }
                );
        }
    }
}
