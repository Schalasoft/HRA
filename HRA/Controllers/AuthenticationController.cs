using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AuthenticationLibrary.Helpers;
using AuthenticationLibrary.Models;
using Microsoft.AspNet.Identity;

namespace HRA.Controllers
{
    public class AuthenticationController : ApiController
    {
        // CDG Fix regions in this file
        #region Public Methods

        // CDG Test method
        [HttpGet]
        public IHttpActionResult tokentest()
        {
            string token = TokenHelper.CreateToken("joe@mail.com");

            return Ok<string>(token);
        }

        [HttpPost]
        public IHttpActionResult Authenticate([FromBody] LoginRequest login)
        {
            // CDG
            // Move this code to a helper in AuthenticationLibrary
            //return LoginHelper.Authenticate(login);

            var loginResponse = new LoginResponse { };
            LoginRequest loginrequest = new LoginRequest { };
            loginrequest.Username = login.Username.ToLower();
            loginrequest.Password = login.Password;

            IHttpActionResult response;
            HttpResponseMessage responseMsg = new HttpResponseMessage();
            bool isUsernamePasswordValid = false;       

            if(login != null)
            isUsernamePasswordValid=loginrequest.Password=="admin" ? true:false;
            // if credentials are valid
            if (isUsernamePasswordValid)
            {
                string token = TokenHelper.CreateToken(loginrequest.Username);
                //loginResponse.responseMsg.Headers.Add("Authorize", token);
                //HttpContext.Current.Response.Headers.Add("Authorize", token); // cdg test
                //HttpContext.Current.Request.Headers.Add("Authorize", token); // cdg test

                //return the token
                //return ResponseMessage(loginResponse.responseMsg);
                return Ok<string>(token);
            }
            else
            {
                // if credentials are not valid send unauthorized status code in response
                loginResponse.responseMsg.StatusCode = HttpStatusCode.Unauthorized;
                response = ResponseMessage(loginResponse.responseMsg);
                return response;
            }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
        #endregion
    }
}
