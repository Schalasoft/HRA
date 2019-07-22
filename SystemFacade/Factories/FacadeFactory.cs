using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Factories;
using HRASystem.Facades;
using HRASystem.Factories;
using DataLibrary.DataAccess;

namespace HRASystem.Factories
{
    public static class FacadeFactory
    {
        public static Facade CreateFacade()
        {
            IDataAccess dataAccess = DatabaseFactory.CreateSqlDataAccess();
            return new Facade(dataAccess);
        }
    }
}
