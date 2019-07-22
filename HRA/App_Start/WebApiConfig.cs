using DataLibrary.DatabaseMapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AuthenticationLibrary.Handlers;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AuthenticationLibrary.Filters;

namespace HRA
{
    public static class WebApiConfig
    {
        #region Public Methods
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Authentication // CDG
            TokenHandler tokenHandler = new TokenHandler();
            config.MessageHandlers.Add(tokenHandler);

            config.Filters.Add(new CustomAPIFilter()); // API request/response filter
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }//,
                //constraints: null,
                //handler: tokenHandler  // per-route message handler
            );

            // Create/Migrate tables
            Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }
        #endregion
    }
}
