using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleAppJc.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnException(ExceptionContext filterContext)
        {
            //I was going to add security but decided to leave it for the time being
            if (filterContext.HttpContext.User != null && filterContext.HttpContext.User.Identity.IsAuthenticated && !ControllerContext.IsChildAction)
            {
                var routeAction = filterContext.RouteData.Values["action"] != null ? filterContext.RouteData.Values["action"].ToString() : String.Empty;

                
            }
            base.OnException(filterContext);
        }
    }
}