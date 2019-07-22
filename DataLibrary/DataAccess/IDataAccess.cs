using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;

namespace DataLibrary.DataAccess
{
    public interface IDataAccess
    {
        int SaveUser(User user);

        List<User> LoadUsers();

        int SaveEmployee(Employee employee);

        List<Employee> LoadEmployees();

        Employee LoadEmployee(int employeeId);

        List<Employee> LoadManagersEmployees(int employeeId);

        List<Employee> LoadHumanResourcesPersonnelsEmployees(int employeeId);

        int RemoveEmployee(Employee employee);

        List<string> GetRolePrivileges(string role);

        bool IsUsernamePasswordValid(string userName, string password);
    }
}
