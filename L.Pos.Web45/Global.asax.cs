using L.Pos.DataAccess.Common;
using L.Pos.DataAccess.Repo;
using NHibernate;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace L.Pos.Web45
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Bootstrap();

        }

        void Bootstrap()
        {
            SessionProvider SessionProvider = new SessionProvider();
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            //container.Register(() => SessionProvider.SessionFactory, Lifestyle.Singleton);
            container.Register<ISessionFactory>(() => SessionProvider.SessionFactory, Lifestyle.Singleton);
            container.Register(typeof(IBaseRepo<>), new[] { typeof(BaseRepo<>).Assembly });
            //container.Register<IUserRepo, UserRepo>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            UserRepo repo = new UserRepo();
            repo.GetOne();
        }
    }
}
