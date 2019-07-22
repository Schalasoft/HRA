using DataLibrary.DatabaseMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataLibrary.Models;
using HRASystem.Factories;
using HRASystem.Facades;
using DataLibrary.Enumerations;
using AuthenticationLibrary.Filters;

namespace HRA.Controllers
{
    //[Authorize] // cdg todo uncomment to lock api
    public class EmployeeController : ApiController
    {
        #region Private Members

        //private DatabaseContext db = new DatabaseContext();
        private List<Employee> employees = new List<Employee>();
        #endregion

        #region Public Methods
        public void Post([FromBody]Employee employee)
        {
            //employees.Add(employee);
            Facade facade = FacadeFactory.CreateFacade();
            facade.DataAccess.SaveEmployee(employee);
        }

        public List<Employee> Get()
        {
            Facade facade = FacadeFactory.CreateFacade();

            CreateSampleData();

            employees = facade.DataAccess.LoadEmployees();

            return employees;
        }

        public Employee Get(int id)
        {
            return employees.Where(x => x.EmployeeId == id).FirstOrDefault();
        }

        public int Delete(int id)
        {
            var employee = employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            //employees.Remove(employee);
            Facade facade = FacadeFactory.CreateFacade();
            return facade.DataAccess.RemoveEmployee(employee);
        }

        private void CreateSampleData()
        {
            Facade facade = FacadeFactory.CreateFacade();

            employees.AddRange(facade.DataAccess.LoadEmployees());

            // CDG fill employee table with test data
            if (employees.Count < 2)
            {
                employees.Add(new Employee
                {
                    EmployeeId = 100000,
                    FirstName = "Jane",
                    SecondName = "Bloggs",
                    AnnualBonus = 10,
                    Department = DepartmentEnum.InformationTechnology.ToString(),
                    EmailAddress = "jane@mail.com",
                    Salary = 20000,
                    VacationBalance = 16
                });

                employees.Add(new Employee
                {
                    EmployeeId = 100001,
                    FirstName = "Joe",
                    SecondName = "Bloggs",
                    AnnualBonus = 20,
                    Department = DepartmentEnum.Operations.ToString(),
                    EmailAddress = "joe@mail.com",
                    Salary = 20000,
                    VacationBalance = 7
                });

                foreach (var employee in employees)
                    facade.DataAccess.SaveEmployee(employee);

                // Sample users
                List<User> users = new List<User>();

                users.Add(new User
                {
                    EmployeeId = 100000,
                    Username = "jane@mail.com",
                    Password = "jane",
                    RoleId = 1
                    //Role = "Employee" // CDG todo Set RoleId using GetRoleId() using name method
                });

                users.Add(new User
                {
                    EmployeeId = 100000,
                    Username = "joe@mail.com",
                    Password = "joe",
                    //Role = "Administrator"
                    RoleId = 0
                });

                foreach (var user in users)
                    facade.DataAccess.SaveUser(user);

            }
        }

        #endregion
    }
}