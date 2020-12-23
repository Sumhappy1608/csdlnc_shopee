using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using csdlnc_shopee.Models;

namespace csdlnc_shopee.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            shopeeEntities2 db = new shopeeEntities2();
            List<HANGHOA> pList = db.HANGHOAs.ToList();
            return View(pList);
            
        }

        public ActionResult ProductMan()
        {
            shopeeEntities2 db = new shopeeEntities2();
            List<HANGHOA> pList = (from HH in db.HANGHOAs
                                   join DM in db.DANHMUCs on HH.LOAIHANGHOA equals DM.MALOAI
                                   where DM.TENLOAI == "MAN"
                                   select HH).ToList();
            return PartialView("_ProductMan", pList);
        }

        //Lấy chi tiết sản phẩm

        public ActionResult ProductDetail(string productID)
        {
            shopeeEntities2 db = new shopeeEntities2();
            HANGHOA product = db.HANGHOAs.Where(x => x.MAHANGHOA == productID).SingleOrDefault();
            return View(product);
        }

        public ActionResult Categories()
        {
            shopeeEntities2 db = new shopeeEntities2();
            List<DANHMUC> cList = db.DANHMUCs.ToList();
            return PartialView("_Categories", cList);
        }
        /*public ActionResult CategoryItem(string categoryID)
        {
            shopeeEntities db = new shopeeEntities();
            List<HANGHOA> cList = db.HANGHOAs.Where(x => x.LOAIHANGHOA == categoryID).ToList();
            return View(cList);
        }*/

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