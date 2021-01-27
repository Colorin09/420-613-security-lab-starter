using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(){
            return View("~/Views/Error/Index.cshtml");
        }

        public ActionResult NotFound()
        {
            ViewBag.CurrentUrl = Request.QueryString["aspxerrorpath"];
            return View("~/Views/Error/Error404.cshtml");
        }

        public ActionResult ServerError()
        {
            return View("~/Views/Error/Error500.cshtml");
        }
    }
}