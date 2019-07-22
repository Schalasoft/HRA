using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using AuthenticationLibrary.Filters;

namespace AuthenticationLibrary.Filters
{
    public class CustomMVCFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionExecutedContext)
        {
            // Get cookie from Web API Response
            /*HttpCookie cookie = System.Web.HttpContext.Current.Response.Cookies.Get("Token");
            string token = "";
            if (cookie.Value != null)
                token = cookie.Value;*/

            // Add to MVC header
            //actionExecutedContext.HttpContext.Request.Headers.Add("Token", token);

            base.OnActionExecuting(actionExecutedContext);
        }
    }
}
