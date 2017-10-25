using L.Pos.DataAccess.Common;
using L.Pos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Repo
{
    public interface ICurrencyRepo : IBaseRepo<Currency>
    {
        void GetOne();
    }

    public class CurrencyRepo : BaseRepo<Currency>, ICurrencyRepo
    {
        //public CurrencyRepo()
        //{
        //    SessionFactory = SessionProvider.SessionFactory2;
        //    Session = SessionFactory.OpenSession();
        //}

        public CurrencyRepo(ISessionProvider _SessionProvider) : base(_SessionProvider)
        {
            SessionProvider = _SessionProvider;
            SessionFactory = SessionProvider.GetSessionFactory("mssqlserverConn2");
            Session = SessionFactory.OpenSession();
        }

        public override IList<Currency> GetAll()
        {
            //SessionFactory = SessionProvider.SessionFactory2;
            //Session = SessionFactory.OpenSession();

            return Session.QueryOver<Currency>().List<Currency>();

        }

        public void GetOne()
        {
        }
    }
}
