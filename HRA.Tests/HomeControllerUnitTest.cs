using System;
using System.Net;
using System.Web.Mvc;
using HRA.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HomeControllerUnitTest
{
    #region Public Methods
    [TestMethod]
    public void IndexViewShouldHaveEmptyViewName()
    {
        HomeController controllerUnderTest = new HomeController();
        var result = controllerUnderTest.Index() as ViewResult;
        Assert.AreEqual("", result.ViewName);
    }

    [TestMethod]
    public void ViewEmployeesReturnsUnauthorizedWithoutToken()
    {
        HomeController controllerUnderTest = new HomeController();
        var result = controllerUnderTest.ViewEmployees() as ContentResult;
        Assert.AreEqual(HttpStatusCode.Unauthorized.ToString(), result.Content);
    }
    #endregion
}
