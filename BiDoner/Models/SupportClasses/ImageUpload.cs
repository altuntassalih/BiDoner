using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace BiDoner.Models.SupportClasses
    {
    public class ImageUpload
    {
        string UploadedFileName;

        internal Tuple<string, string> ImageResize(HttpPostedFileBase FileUpload1, int genislik, int yukseklik, int buyukGenislik, int buyukYukseklik)
        {
            string dosyaAdi = FileUpload1.FileName.Replace(" ","");
            UploadedFileName = HttpContext.Current.Server.MapPath("~/Images/Upload/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi);
            string fileType = FileUpload1.FileName.Split('.')[FileUpload1.FileName.Split('.').Length - 1];
            string resim = string.Empty;
            Bitmap yeniresim = null;
            yeniresim = ResimBoyutlandir(FileUpload1.InputStream, buyukGenislik, buyukYukseklik);//yeni resim için boyut veriyoruz..
            yeniresim.Save(UploadedFileName,ImageFormat.Jpeg);
            UploadedFileName = "~/Images/Upload/" + UploadedFileName.Split('\\')[UploadedFileName.Split('\\').Length - 1].ToString();


            string imageUrlThumbnail = HttpContext.Current.Server.MapPath("~/Images/Thumbnails/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi);
            System.Drawing.Image i = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath(UploadedFileName));
            System.Drawing.Image thumbnail = new System.Drawing.Bitmap(genislik, yukseklik);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(thumbnail);
            g.DrawImage(i, 0, 0, genislik, yukseklik);

            thumbnail.Save(imageUrlThumbnail);
            return new Tuple<string, string>("Images/Upload/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi, "/Images/Thumbnails/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi);
        }
        internal  string ImageResize(HttpPostedFileBase FileUpload1, int genislik, int yukseklik)
        {
            string dosyaAdi = FileUpload1.FileName.Replace(" ", "");
            UploadedFileName = HttpContext.Current.Server.MapPath("~/Images/Thumbnails/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi);
            Bitmap yeniresim = null;
            yeniresim = ResimBoyutlandir(FileUpload1.InputStream, genislik, yukseklik);//yeni resim için boyut veriyoruz..
            yeniresim.Save(UploadedFileName, ImageFormat.Jpeg);
            return "/Images/Thumbnails/" + DateTime.Now.ToShortDateString().Trim().Replace(':', '_').Replace('.', '_') + dosyaAdi;
        }
        private Bitmap ResimBoyutlandir(Stream resim, int genislik, int yukseklik)
        {
            Bitmap orjinalresim = new Bitmap(resim);
            int yenigenislik = orjinalresim.Width;
            int yeniyukseklik = orjinalresim.Height;
            double enboyorani = Convert.ToDouble(orjinalresim.Width) / Convert.ToDouble(orjinalresim.Height);

            if (enboyorani <= 1 && orjinalresim.Width > genislik)
            {
                yenigenislik = genislik;
                yeniyukseklik = Convert.ToInt32(Math.Round(yenigenislik / enboyorani));
            }
            else if (enboyorani > 1 && orjinalresim.Height > yukseklik)
            {
                yeniyukseklik = yukseklik;
                yenigenislik = Convert.ToInt32(Math.Round(yeniyukseklik * enboyorani));
            }
            return new Bitmap(orjinalresim, yenigenislik, yeniyukseklik);
        }
    }
}