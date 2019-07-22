using Autofac.Extras.Moq;
using DataLibrary.DataAccess;
using DataLibrary.Models;
using HRA.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class EmployeeControllerUnitTest
{
    /*
    [TestMethod]
    public void GetReturnsAllEmployees()
    {
        EmployeeController controllerUnderTest = new EmployeeController();
        List<Employee> result = controllerUnderTest.Get() as List<Employee>;
        Assert.AreEqual(result.Count, 2);
    }

    [TestMethod]
    public void GetWithIdReturnsCorrectEmployee()
    {
        using(var mock = AutoMock.GetLoose())
        {
            mock.Mock<ISqlDataAccess>()
                .Setup(x => x.LoadEmployee(100000))
                .Returns(GetSampleEmployee());

            var cls = mock.Create<SqlDataAccess>();
            var expected = GetSampleEmployee();
            var actual = cls.LoadEmployee(100000);

            Assert.IsTrue(actual != null);
            Assert.Equals(expected, actual);
        }
    }
    */

    private Employee GetSampleEmployee()
    {
        Employee employee = new Employee
        {
            EmployeeId = 100000
        };

        return employee;
    }
}
