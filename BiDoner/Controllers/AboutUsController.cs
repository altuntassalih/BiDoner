using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Controllers
{
    public class AboutUsController : Controller
    {
        [Route("Hakkimizda")]
        public ActionResult Hakkimizda()
        {
            ViewBag.Current = "Hakkimizda";
            return View();
        }

    }
}