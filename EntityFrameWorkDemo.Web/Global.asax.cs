using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EntityFrameWorkDemo.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
		
		/// <summary>
        /// Handles error on Application.
        /// </summary>
        /// <param name="sender">Contains sender object.</param>
        /// <param name="e">Contains EventArgs object.</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            HttpContext httpContext = ((MvcApplication)sender).Context;

            //LogException(httpContext, Server.GetLastError());

            httpContext.ClearError();
            httpContext.Response.Clear();

            if (httpContext.Request.Headers["X-Requested-With"] != null && !string.IsNullOrEmpty(Convert.ToString(httpContext.Request.Headers["X-Requested-With"])) && Convert.ToString(httpContext.Request.Headers["X-Requested-With"]) == "XMLHttpRequest")
            {
                // For Ajax call exceptions
                UrlHelper url = new UrlHelper(httpContext.Request.RequestContext);
                var error = new { error = "AjaxError", errorurl = url.Action("Error", "Error", string.Empty, url.RequestContext.HttpContext.Request.Url.Scheme) };
                Response.ContentType = "application/json; charset=utf-8";
                Response.Write(new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(error));
                Response.End();
            }
            else
            {
                var controller = new Controllers.ErrorController();
                var routeData = new RouteData();

                routeData.Values["controller"] = "Error";
                routeData.Values["action"] = "Error";

                ((IController)controller).Execute(new RequestContext(new HttpContextWrapper(httpContext), routeData));
            }
        }
		
    }
}
