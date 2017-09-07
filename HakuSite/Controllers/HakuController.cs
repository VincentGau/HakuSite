using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HakuSite.Controllers
{
    public class HakuController : Controller
    {
        // GET: Haku
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int times = 1)
        {
            ViewBag.Message = "Hello, " + name;
            ViewBag.times = times;

            return View();
        }
    }
}