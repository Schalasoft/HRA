using System;
using DataLibrary.Factories;
using HRASystem.Factories;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace HRASystem.Facades
{
    public class Facade
    {
        // Should be protected, using methods to allow access to inner class
        public IDataAccess DataAccess;

        public Facade(IDataAccess dataAccess)
        {
            this.DataAccess = dataAccess;
        }

        public string Operation()
        {
            return "Facade Operation";
        }
    }

    public class DataAccess
    {
        public string operation1()
        {
            return "DataAccess Operation 1\n";
        }

        public string operation2()
        {
            return "DataAccess Operation 2\n";
        }
    }

    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataAccess sqlDataAccess = DatabaseFactory.CreateSqlDataAccess();
            Facade facade = new Facade(sqlDataAccess);
            Client.ClientCode(facade);
        }
    }
}