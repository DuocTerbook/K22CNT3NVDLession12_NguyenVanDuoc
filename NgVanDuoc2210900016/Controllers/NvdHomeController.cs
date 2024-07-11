using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgVanDuoc2210900016.Controllers
{
    public class NvdHomeController : Controller
    {
        public ActionResult NvdIndex()
        {
            return View();
        }

        public ActionResult NvdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NvdContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}