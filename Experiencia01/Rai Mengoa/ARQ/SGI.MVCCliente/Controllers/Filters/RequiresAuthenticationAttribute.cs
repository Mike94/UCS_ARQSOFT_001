using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Routing;


namespace SGI.MVCCliente.Controllers.Filters
{
    public class RequiresAuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            String stringUrl = filterContext.HttpContext.Request.Url.PathAndQuery;

            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                if ((!filterContext.HttpContext.Request.IsAuthenticated) || (HttpContext.Current.Session["Usuario"] == null))
                {
                    JavaScriptResult result = new JavaScriptResult()
                    {
                        Script = "window.location='" + "/Cuenta/IniciarSesion?stringUrl=" + stringUrl + "';"
                    };
                    filterContext.Result = result;
                }
            }
            else
            {
                if (!filterContext.HttpContext.Request.IsAuthenticated || (HttpContext.Current.Session["Usuario"] == null))
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(new
                        {
                            controller = "Cuenta",
                            action = "IniciarSesion",
                            stringUrl = stringUrl
                        }
                    ));
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }  
}
