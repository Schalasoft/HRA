using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRA.Controllers
{
    public class AuthorizationController : ApiController
    {
        #region Public Methods
        public bool isAuthorized()
        {
            return true;
        }
        #endregion
    }
}
