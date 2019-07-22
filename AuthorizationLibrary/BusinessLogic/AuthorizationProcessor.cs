using AuthorizationLibrary.Enumerations;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRASystem.Facades;
using HRASystem.Factories;
using DataLibrary.DataAccess;

namespace AuthorizationLibrary.BusinessLogic
{
    public class AuthorizationProcessor
    {
        static Facade _facade = null;

        public AuthorizationProcessor()
        {
            _facade = FacadeFactory.CreateFacade();
        }

        public List<Employee> GetAuthorizedEmployees(User user)
        {
            List<Employee> employees = new List<Employee>();

            int employeeId = user.EmployeeId;
            //string role = user.Role;

            // cdg todo get user role from roleid method
            string role = "Administrator";
            switch (role)
	        {

                case "Employee":
                    employees.Add(_facade.DataAccess.LoadEmployee(employeeId));
                break;

                case "Manager":
                    employees = _facade.DataAccess.LoadManagersEmployees(employeeId);
                    break;

                case "HumanResourcesPersonnel":
                    employees = _facade.DataAccess.LoadHumanResourcesPersonnelsEmployees(employeeId);
                    break;

                case "Administrator":
                    employees = _facade.DataAccess.LoadEmployees();
                    break;
            }

            return employees;
        }

        public List<string> GetPrivilegesForRole(string role)
        {
            List<string> privileges = new List<String>();

            privileges = _facade.DataAccess.GetRolePrivileges(role);

            return privileges;
        }


    }
}
