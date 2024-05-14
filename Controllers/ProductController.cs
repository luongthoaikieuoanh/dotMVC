using dotMVC.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
                size = i.idsize.ToString();
            }
            ViewData["size"] = size;


            var mausacs = (from cth in db.cthanghoas
                           join mau in db.mausacs on cth.idmau equals mau.Idmau
                           where cth.idhanghoa == hh.mahh
                           select new
                           {
                               mau.Idmau,
                           }).Distinct().Count();

            ViewData["color"] = mausacs.ToString();


            var productPrice = db.cthanghoas.Where(x => x.idhanghoa == hh.mahh).Select(x => x.dongia).FirstOrDefault();

            // Lưu giá vào ViewData để sử dụng trong view
            ViewData["ProductPrice"] = productPrice;

            // Lấy giảm giá của sản phẩm từ cơ sở dữ liệu
            var productDiscount = db.cthanghoas.Where(x => x.idhanghoa == hh.mahh).Select(x => x.giamgia).FirstOrDefault();

            // Lưu giảm giá vào ViewData để sử dụng trong view
            ViewData["ProductDiscount"] = productDiscount;

            return PartialView(cthh);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = db.hanghoas.Where(a => a.mahh == id).ToList();
         //  var x = db.cthanghoas.Where(s => s.idhanghoa == id).ToList();
           ViewData["CTHangHoa"] = db.cthanghoas.Where(s => s.idhanghoa == id).ToList();
            /*  var query = from c in db.cthanghoas
                          join m in db.mausacs on c.idmau equals m.Idmau into joined
                          from subm in joined.DefaultIfEmpty()
                          where c.idhanghoa == 2
                          group new { c, subm } by new { c.idhanghoa, c.idmau, subm.mausac1 } into grp
                          select new
                          {
                              IdHangHoa = grp.Key.idhanghoa,
                              IdMau = grp.Key.idmau,
                              MauSac = grp.Key.mausac1
                          };*/
            // Lấy đường dẫn hình ảnh từ cơ sở dữ liệu
            var productImage = db.cthanghoas.Where(x => x.idhanghoa == id).Select(x => x.hinh).FirstOrDefault();

            // Trích xuất tên hình ảnh từ đường dẫn
            var imageName = System.IO.Path.GetFileName(productImage);
            // Lấy giá của sản phẩm từ cơ sở dữ liệu
            var productPrice = db.cthanghoas.Where(x => x.idhanghoa == id).Select(x => x.dongia).FirstOrDefault();

            // Lưu giá vào ViewData để sử dụng trong view
            ViewData["ProductPrice"] = productPrice;

            // Lấy giảm giá của sản phẩm từ cơ sở dữ liệu
            var productDiscount = db.cthanghoas.Where(x => x.idhanghoa == id).Select(x => x.giamgia).FirstOrDefault();

            // Lưu giảm giá vào ViewData để sử dụng trong view
            ViewData["ProductDiscount"] = productDiscount;

            // Lưu tên hình ảnh vào ViewData để sử dụng trong view
            ViewData["ProductImageName"] = imageName;

            ViewData["Size"] = (from cth in db.cthanghoas
                                join sg in db.sizegiays on cth.idsize equals sg.Idsize
                                where cth.idhanghoa == id
                                select sg).Distinct().ToList();

            ViewData["Colors"] = (from cth in db.cthanghoas
                                  join sg in db.mausacs on cth.idmau equals sg.Idmau
                                  where cth.idhanghoa == id
                                  select sg).Distinct().ToList();

            ViewData["Image"] = (from cth in db.hanghoas
                                 join sg in db.anhcts on cth.mahh equals sg.mahh
                                 where cth.mahh == id
                                 select sg).Distinct().ToList();

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }


    }
}