using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WioShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() 
        {
            return View();
        }

        public ActionResult Products() 
        {
            return View();
        }
    }
}