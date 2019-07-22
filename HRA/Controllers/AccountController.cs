using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AuthenticationLibrary.Helpers;
using AuthenticationLibrary.Models;
using HRA.Controllers;
using HRA.Models;
using HRASystem.Facades;
using HRASystem.Factories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;

namespace TsysTechnicalAudition.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        #region Public Methods
        // Do not lock down the login page
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        // CDG Fix warning
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            //if (!ModelState.IsValid)
            {
                LoginRequest loginRequest = new LoginRequest();
                loginRequest.Username = model.Email;
                loginRequest.Password = model.Password;

                bool isUsernamePasswordValid = false;
                // CDG Link to table in database, any user with password "admin" can log in for testing
                //if (model != null)
                //    isUsernamePasswordValid = model.Password == "admin" ? true : false;

                Facade facade = FacadeFactory.CreateFacade();
                isUsernamePasswordValid = facade.DataAccess.IsUsernamePasswordValid(loginRequest.Username, loginRequest.Password);

                // if credentials are valid
                if (isUsernamePasswordValid)
                {
                    string token = TokenHelper.CreateToken(loginRequest.Username);
                    
                    // CDG this should be put into request headers, not stored locally
                    TokenHelper.CurrentToken = token;

                    //return (token);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // if credentials are not valid send unauthorized status code in response
                    // loginResponse.responseMsg.StatusCode = HttpStatusCode.Unauthorized;
                    // response = ResponseMessage(loginResponse.responseMsg);
                    // return response;
                }

                return View(model);
            }
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}