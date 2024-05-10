using dotMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotMVC.Controllers
{
    public class HomeController : Controller
    {
        private ShopGNam3Context db = new ShopGNam3Context();

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Navbar()
        {
            return PartialView();
        }
        public ActionResult About()
        {
            ViewData["title"] = "Giới thiệu";

            return View();
        }
        public ActionResult Contact()
        {
            ViewData["title"] = "Liên hệ";


            return View();
        }
        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }
        

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}