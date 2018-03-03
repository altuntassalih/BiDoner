using BiDoner.DAL.Concrete;
using BiDoner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Controllers
{
    public class HomeController : Controller
    {


        //[Route("Anasayfa")]
        public ActionResult Anasayfa()
        {

            IEnumerable<Category> categoryList = new CategoryDAL().GetAllActiveCategories();
            IEnumerable<Product> productList = new ProductDAL().GetActiveProducts();
            ViewBag.Current = "Index";
            ViewBag.categoryList = categoryList.Where(x => x.IsHomePageCategory == true).ToList();

            return View(productList);
        }

    }
}
