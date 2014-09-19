// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRoute.cs" company="HP">
//   Copyright © 2014 HP
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.LearnSchool.Routing
{
    using System.Web.Routing;

    public class DefaultRoute : Route
    {
        public DefaultRoute()
            : base("{*path}", new DefaultRouteHandler())
        {
            this.RouteExistingFiles = false;
        }
    }
}
