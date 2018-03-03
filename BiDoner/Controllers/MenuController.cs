using BiDoner.DAL.Concrete;
using BiDoner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Controllers
{
    public class MenuController : Controller
    {
        [Route("Menu")]
        public ActionResult Menu()
        {
            ProductDAL proMng = new ProductDAL();
            CategoryDAL catDal = new CategoryDAL();

            var productList = proMng.GetActiveProducts();
            var categoryList = catDal.GetAllActiveCategories();
            ViewData["Current"] = "Menu";
            GeneralMenuModel generalModel = new GeneralMenuModel();

            generalModel.ProductList = productList;
            generalModel.CategoryList = categoryList;

            return View(generalModel);
        }
    }
}