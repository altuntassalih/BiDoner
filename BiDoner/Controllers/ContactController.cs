using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Controllers
{
    public class ContactController : Controller
    {
        [Route("İletisim")]
        public ActionResult Iletisim()
        {
            ViewBag.Current = "Iletisim";
            return View();
        }
    }
}