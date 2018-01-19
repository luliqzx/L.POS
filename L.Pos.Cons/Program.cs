using L.Pos.DataAccess.Common;
using L.Pos.DataAccess.Repo;
using L.Pos.Model;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Cons
{
    class Program
    {
        static readonly Container container;

        static Program()
        {
            container = new Container();
            Bootstrap();
        }

        static void Main(string[] args)
        {
            IUserRepo userRepo = container.GetInstance<IUserRepo>();
            IList<User> a = userRepo.GetAll();
            ICurrencyRepo CurrencyRepo = container.GetInstance<ICurrencyRepo>();
            IList<Currency> b = CurrencyRepo.GetAll();
             
        }

        static void Bootstrap()
        {
            //SessionProvider SessionProvider = new SessionProvider();
            // Create the container as usual.

            // Register your types, for instance:
            container.Register<ISessionProvider, SessionProvider>(Lifestyle.Singleton);
            container.Register<IUserRepo, UserRepo>();
            container.Register<ICurrencyRepo, CurrencyRepo>();

            // This is an extension method from the integration package.

            container.Verify();
        }
    }
}
