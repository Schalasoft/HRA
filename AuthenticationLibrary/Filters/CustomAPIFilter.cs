using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using AuthenticationLibrary.Filters;

namespace AuthenticationLibrary.Filters
{
    public class CustomAPIFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //actionExecutedContext.Response.Content.Headers.Add("name", "value");

            //ObjectContent content = actionExecutedContext.Response.Content as ObjectContent;
            string token = null;
            actionExecutedContext.Response.TryGetContentValue(out token);
            token = "Bearer " + token;

            /*
            System.Web.HttpContext.Current.Response.Cookies.Add(new System.Web.HttpCookie("Token")
            {
                Value = token,
                HttpOnly = true
            });

            //actionExecutedContext.Request.Content.Headers.Add("Authorization", token);

            /* using (var client = new HttpClient())
             {
                 client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
             }*/
        }
    }
}
