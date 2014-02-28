﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Femah.Examples.Additionator.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{firstNumber}/{secondNumber}"
            );
        }
    }
}
