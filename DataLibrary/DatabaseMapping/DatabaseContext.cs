namespace DataLibrary.DatabaseMapping
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataLibrary.Models;
    using System.Collections.Generic;
    using System.Collections;

    public class DatabaseContext : DbContext
    {
        #region Public Methods
        public DatabaseContext() : base("name=DatabaseContext") { }
        //public DatabaseContext() : base(GetEnvironmentVariableConnectionString()) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ReportsToMapping> ReportsToMapper { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<RolePrivilegeMapping> RolePrivilegeMapping { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupUserMapping> GroupUserMapping { get; set; }
        public DbSet<GroupPrivilegeMapping> GroupPrivilegeMapping { get; set; }
        public DbSet<SalaryHistory> SalaryHistory { get; set; }
        public DbSet<User> Users { get; set; }

        public static string GetEnvironmentVariableConnectionString()
        {
            return Environment.GetEnvironmentVariable("HRA_ConnectionString", EnvironmentVariableTarget.User);
        }
        #endregion
    }
}
