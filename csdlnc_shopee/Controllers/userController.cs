using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace csdlnc_shopee.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult account()
        {
            return View();
        }
    }
}