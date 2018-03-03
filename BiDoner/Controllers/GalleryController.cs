using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Galeri()
        {
            ViewBag.Current = "Galeri";
            return View();
        }
    }
}