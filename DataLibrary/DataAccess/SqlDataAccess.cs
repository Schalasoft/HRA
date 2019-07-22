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
    public class SqlDataAccess : IDataAccess
    {
        // CDG Split into User, Employee, Authorization
        // CDG missing update for entities
        #region Public Methods

        public int SaveUser(User user)
        {
            using (var db = new DatabaseContext())
            {
                db.Users.Add(user);
                return db.SaveChanges();
            }
        }

        public List<User> LoadUsers()
        {
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Users
                            orderby b.Username
                            select b;

                return query.ToList();
            }
        }

        public int SaveEmployee(Employee employee)
        {
            using (var db = new DatabaseContext())
            {
                db.Employees.Add(employee);
                return db.SaveChanges();
            }
        }

        public List<Employee> LoadEmployees()
        {
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Employees
                            orderby b.EmployeeId
                            select b;

                return query.ToList();
            }
        }

        public Employee LoadEmployee(int employeeId)
        {
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Employees
                            where employeeId == b.EmployeeId
                            select b;

                return query.FirstOrDefault();
            }
        }

        public List<Employee> LoadManagersEmployees(int employeeId)
        {
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Employees
                            // CDG TODO
                            // List all ReportTo users for employeeId
                            select b;

                return query.ToList();
            }
        }

        public List<Employee> LoadHumanResourcesPersonnelsEmployees(int employeeId)
        {
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Employees
                            // CDG TODO join query, no duplicates
                            // List all users that are not in HR
                            // and
                            // List all ReportsTo users for employeeId
                            select b;

                return query.ToList();
            }
        }

        public int RemoveEmployee(Employee employee)
        {
            using (var db = new DatabaseContext())
            {
                db.Employees.Remove(employee);
                return db.SaveChanges();
            }
        }

        public List<string> GetRolePrivileges(string role)
        {
            // CDG todo

            using (var db = new DatabaseContext())
            {
                // Get user role id from name
                var roleQuery = from a in db.Roles
                                where a.Name == role
                                select a;

                // Get privileges from role
                var rolePrivilegeQuery = from b in db.RolePrivilegeMapping
                            where b.RoleId == role
                            select b;

                //var privilegeQuery = from c in db.Privileges;

                // Get mappings
                //RolePrivilegeMapping mapping = query.FirstOrDefault();


                List<string> privileges = new List<String>();

                return privileges;
            }
        }

        public bool IsUsernamePasswordValid(string userName, string password)
        {
            // CDG TODO
            using (var db = new DatabaseContext())
            {
                var query = from b in db.Users
                            where b.Username == userName
                            select b;

                User user = query.FirstOrDefault();

                if (user != null)
                    if (user.Password == password)
                        return true;
            }

            return false;
        }
        #endregion
    }
}
