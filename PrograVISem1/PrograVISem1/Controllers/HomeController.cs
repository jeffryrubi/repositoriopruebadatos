using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrograVISem1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var usuario = Session["Usuario"];
            if(usuario != null) {
                ViewBag.Message = usuario;
            }
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
    }
}