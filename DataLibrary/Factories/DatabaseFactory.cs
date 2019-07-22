using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Factories
{
    public static class DatabaseFactory
    {
        public static SqlDataAccess CreateSqlDataAccess()
        {
            return new SqlDataAccess();
        }
    }
}