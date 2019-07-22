using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataLibrary.Models;
using DataLibrary.DatabaseMapping;

namespace DataLibrary.DataAccess
{
    public class OracleDataAccess : IDataAccess
    {
        #region Public Methods

        public int SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> LoadUsers()
        {
            throw new NotImplementedException();
        }

        public int SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> LoadEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee LoadEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> LoadManagersEmployees(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> LoadHumanResourcesPersonnelsEmployees(int employeeId)
        {
            throw new NotImplementedException();
        }

        public int RemoveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<string> GetRolePrivileges(string role)
        {
            throw new NotImplementedException();
        }

        public bool IsUsernamePasswordValid(string userName, string password)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
