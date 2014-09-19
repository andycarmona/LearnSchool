// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="HP">
//   Copyright © 2014 HP
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.LearnSchool
{
    using System.Web.Routing;

    using App.LearnSchool.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
