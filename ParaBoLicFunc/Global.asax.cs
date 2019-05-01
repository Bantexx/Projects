using ParaBoLicFunc.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ParaBoLicFunc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ClearFiles.ClearFile();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);          
        }
    }
}
