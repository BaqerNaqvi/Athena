using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Athena_POC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BMU()
        {
            return View();
        }

        public ActionResult LTHW()
        {
            return View(); 
        }

        public ActionResult Light()
        {
            return View();
        }
    }
}