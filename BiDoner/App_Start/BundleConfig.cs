using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BiDoner.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {


          //  //_Layout - css
          //  bundles.Add(new StyleBundle("~/style/_Layout").Include(
          //    "~/Content/css/bootstrap.min.css",
          //    "~/Content/css/font-awesome.min.css",
          //    "~/Content/css/elixir.css",
          //    "~/Content/css/YTPlayer.css",
          //    "~/Content/css/swipebox.css",
          //    "~/Scripts/owl-carousel/owl.carousel.css",
          //    "~/Scripts/owl-carousel/owl.theme.css",
          //    "~/Scripts/owl-carousel/owl.transitions.css"));

          //  //_Layout - js
          //  bundles.Add(new ScriptBundle("~/script/_Layout").Include(
          //     "~/Scripts/modernizr.custom.js",
          //    "~/Scripts/jquery.js",
          //    "~/Scripts/classie.js",
          //    "~/Scripts/pathLoader.js",
          //    "~/Scripts/owl-carousel/owl.carousel.min.js",
          //     "~/Scripts/jquery.inview.js",
          //     "~/Scripts/jquery.nav.js",
          //     "~/Scripts/jquery.mb.YTPlayer.js",
          //     "~/Scripts/jquery.form.js",
          //     "~/Scripts/jquery.validate.js",
          //     "~/Scripts/bootstrap.min.js",
          //     "~/Scripts/default.js",
          //     "~/Scripts/plugins.js",
          //     "~/Scripts/jquery.isotope.min.js",
          //     "~/Scripts/jquery.prettyPhoto.js",
          //     "~/Scripts/jquery.swipebox.js"
          //      ));



          //  //BrandList - css  
          //  bundles.Add(new StyleBundle("~/StyleCss/BrandList").Include(
             
          //    ));

          //  //Brandlist - js
          //  bundles.Add(new ScriptBundle("~/js/BrandList").Include(
            
          //));



            //Release Modda Burası Aktif Edilip WebConfig deki <compilation debug="true" targetFramework="4.5"/> debug false
            //yapılacak. Css v js dosylarına minmize edip tek bir dosya halinde gösterecek

            //BundleTable.EnableOptimizations = true;
        }
    }
}