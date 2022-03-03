using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USMarines.com.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Life()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}