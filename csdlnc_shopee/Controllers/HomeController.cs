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
            shopeeEntities db = new shopeeEntities();
            List<HANGHOA> pList = db.HANGHOAs.ToList();
            return View(pList);
        }

        //Lấy chi tiết sản phẩm

        public ActionResult ProductDetail(string productID)
        {
            shopeeEntities db = new shopeeEntities();
            HANGHOA product = db.HANGHOAs.Where(x => x.MAHANGHOA == productID).SingleOrDefault();
            return View(product);
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