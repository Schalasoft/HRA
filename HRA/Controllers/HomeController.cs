using AuthenticationLibrary.Helpers;
using DataLibrary.Models;
using HRASystem.Facades;
using HRASystem.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AuthorizationLibrary.BusinessLogic;
using AuthorizationLibrary.Enumerations;
using AuthenticationLibrary.Filters;

namespace HRA.Controllers
{
    public class HomeController : Controller
    {
        #region Public Methods
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //CDG Add token to header so Authorize will work based on roles
        //[Authorize]
        public ActionResult ViewEmployees()
        {
            // Use helper for testing until header has token
            // cdg test
            if(TokenHelper.CurrentToken == null)
                return Content(HttpStatusCode.Unauthorized.ToString(), "Please log in");

            ViewBag.Title = "View Employees";

            User user = new User();
            user.EmployeeId = 100000;
            //user.Role = RoleEnum.Employee.ToString();

            //Facade facade = FacadeFactory.CreateFacade();
            //var data = facade.DataAccess.LoadEmployees();
            AuthorizationProcessor authProcessor = new AuthorizationProcessor();
            var data = authProcessor.GetAuthorizedEmployees(user);

            return View(data);
        }
        
        #endregion
    }
}
