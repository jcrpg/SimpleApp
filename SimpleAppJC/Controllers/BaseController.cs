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
            if (filterContext.HttpContext.User != null && filterContext.HttpContext.User.Identity.IsAuthenticated && !ControllerContext.IsChildAction)
            {
                //This performs a global check, to ensure the default system generated password is changed on first login.
                var routeAction = filterContext.RouteData.Values["action"] != null ? filterContext.RouteData.Values["action"].ToString() : String.Empty;

                
            }
            base.OnException(filterContext);
        }
    }
}