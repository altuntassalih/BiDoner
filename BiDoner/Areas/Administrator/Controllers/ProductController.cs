using BiDoner.Areas.Administrator.CustomFilter;
using BiDoner.DAL.Concrete;
using BiDoner.Models;
using BiDoner.Models.SupportClasses;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Areas.Administrator.Controllers
{
    //[LoginFilter]
    public class ProductController : Controller
    {
        ProductDAL proMng = new ProductDAL();
        // GET: Administrator/Product

        public ActionResult UrunIslemleri()
        {
            CategoryDAL catMng = new CategoryDAL();

            ViewBag.categoryList = new SelectList(catMng.GetAllActiveCategories().ToList(), "CategoryId", "CategoryName");

            List<Product> productList = proMng.GetAll();
            return View(productList);
        }

        public ActionResult ProductProcess(Product entity, HttpPostedFileBase file, string isNew)
        {

            if (file != null && file.ContentLength > 0 && file.ContentLength < 10485760)
            {

                ImageUpload imageUpload = new ImageUpload();

                string imagePath = imageUpload.ImageResize(file, 673, 483);

                if (isNew != "true")
                {
                    string filePath = Server.MapPath(entity.PictureUrl);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                entity.PictureUrl = imagePath;
            }

            if (isNew == "true")
            {
                int addResult = proMng.Add(entity);

            }
            else
            {
                bool updateResult = proMng.Update(entity);

            }

            return RedirectToAction("UrunIslemleri", "Product");

        }


        public JsonResult GetDetailProduct(string id)
        {
            Product product = proMng.Get(id);

            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}