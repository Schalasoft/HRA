using AuthenticationLibrary.Filters;
using System.Web;
using System.Web.Mvc;

namespace HRA
{
    public class FilterConfig
    {
        #region Public Methods
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomMVCFilter()); // MVC request/response filter
        } 
        #endregion
    }
}
