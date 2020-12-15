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