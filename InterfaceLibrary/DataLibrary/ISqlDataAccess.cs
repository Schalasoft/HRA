using InterfaceLibrary.DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary.DataLibrary
{
    public interface ISqlDataAccess
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
    }
}
