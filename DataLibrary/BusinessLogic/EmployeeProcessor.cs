using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataLibrary.DataAccess;
using DataLibrary.Enumerations;
using DataLibrary.Factories;

namespace DataLibrary.BusinessLogic
{
    // Used currently
    // Handle employee objects
    public static class EmployeeProcessor
    {
        #region Public Methods
        public static int CreateEmployee(int employeeId, string firstName,
            string secondName, string emailAddress, decimal salary, 
            string salaryHistory, decimal vacationBalance, decimal annualBonus, 
            DepartmentEnum department)
        {
            Employee data = new Employee
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                SecondName = secondName,
                EmailAddress = emailAddress,
                Salary = salary,
                VacationBalance = vacationBalance,
                AnnualBonus = annualBonus,
                Department = department.ToString(),
            };

            return DatabaseFactory.CreateSqlDataAccess().SaveEmployee(data);
        }

        /*
        public static List<Employee> LoadEmployees()
        {
            return SqlDataAccess.LoadEmployees();
        }
        */

        #endregion
    }
}
