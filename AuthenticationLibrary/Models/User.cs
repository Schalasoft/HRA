using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AuthenticationLibrary.Models
{
    public class User
    {
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class LoginRequest
    {
        #region Members
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion
    }

    public class LoginResponse
    {
        #region Constructors
        public LoginResponse() {
        
            this.Token="";
            this.responseMsg = new HttpResponseMessage() {StatusCode=System.Net.HttpStatusCode.Unauthorized }; 
        }
        #endregion

        #region Members
        public string Token { get; set; }
        public HttpResponseMessage responseMsg { get; set; }
        #endregion
    }
}