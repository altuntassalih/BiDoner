using BiDoner.DAL.Concrete;
using BiDoner.Models;
using BiDoner.Models.SupportClasses;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace BiDoner.Areas.Administrator.Controllers
{
    public class CategoryController : Controller
    {
         CategoryDAL catMng = new CategoryDAL();

        public ActionResult Kategoriİslemleri()
        {
            return View(catMng.GetAll());
        }

        [HttpPost]
        public ActionResult CategoryProcess(Category entity, HttpPostedFileBase file, string isNew)
        {
            if (file != null && file.ContentLength > 0 && file.ContentLength < 10485760)
            {
                string imagePath = new ImageUpload().ImageResize(file, 673, 483);

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
                int result = catMng.Add(entity);
            }
            else 
            {
                bool updateResult = catMng.Update(entity);
            }

            return RedirectToAction("Kategoriİslemleri", "Category");
        }

        [HttpPost]
        public JsonResult GetDetailCategory(string id)
        {
            return Json(catMng.Get(id),JsonRequestBehavior.AllowGet);
        }
    }
}