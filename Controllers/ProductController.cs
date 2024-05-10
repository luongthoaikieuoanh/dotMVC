using dotMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotMVC.Controllers
{
    public class ProductController : Controller
    {
        private ShopGNam3Context db = new ShopGNam3Context();

        public ActionResult Index()
        {
            var sp = db.hanghoas.ToList();
            return View(sp);
        }

        [ChildActionOnly]
        public ActionResult itemProduct(hanghoa hh)
        {
            ViewData["tenhh"] = hh.tenhh;
            var cthh_db = db.cthanghoas.Where(m => m.idhanghoa == hh.mahh).ToList();
            var cthh = cthh_db.Take(1).SingleOrDefault();
            cthh_db = cthh_db.Where(m => m.idhanghoa == hh.mahh && m.mausac == cthh.mausac).ToList(); 
            String size = "";
            foreach (var i in cthh_db) {
                size += i.idsize + "/";
            }
            size = size.Substring(0, size.Length - 1);
            ViewData["size"] = size;
            return PartialView(cthh);
        }
        public ActionResult Details()
        {
            ViewData["title"] = "Chi tiết sản phẩm";

            return View();
        }

    }
}