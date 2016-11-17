using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Net.Application.Shop.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RepositoryModule.Initialize();
            CoreModule.Initialize();
            Net.Framework.Entity.IocInstaller.Init();
            //Net.General.Dependency.MVC.WindsorControllerFactory.Register(Assembly.GetExecutingAssembly());
        }
    }
}
