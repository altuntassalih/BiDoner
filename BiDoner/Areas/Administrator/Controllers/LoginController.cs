using BiDoner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Areas.Administrator.Controllers
{
    public class LoginController : Controller
    {
        // GET: Administrator/Login
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName == "bkdadmin" && user.Password == "bkd3111611")
                {

                    Session["Login"] = user;

                    return RedirectToAction("UrunIslemleri", "Product");
                }
            }

           
            
            return View();
        }


        public ActionResult Cikis()
        {
            Session["EfarLogin"] = null;
            return RedirectToAction("Giris", "Login");
        }
    }
}