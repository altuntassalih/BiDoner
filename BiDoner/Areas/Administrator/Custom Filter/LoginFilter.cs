
using BiDoner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BiDoner.Areas.Administrator.CustomFilter
{
    public class LoginFilter : FilterAttribute, IActionFilter
    {
        // Metod çalıştırıldıktan sonra devreye giren metot.
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
          
        }


        // Metod tetiklendiği anda devreye giren metot.
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

         
            var sesionControl = filterContext.HttpContext.Session["Login"];

            if (sesionControl == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Login" }, { "action", "Giris" } });
            }

        }

    }
}