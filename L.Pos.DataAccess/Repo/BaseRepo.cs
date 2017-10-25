using L.Pos.DataAccess.Common;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using NHibernate.Linq;

namespace L.Pos.DataAccess.Repo
{
    public interface IBaseRepo<T> where T : class
    {
        //ISessionFactory SessionFactory { get; set; }
        IList<T> GetAll();
        T GetBy(Expression<Func<T, bool>> expfunc);
    }
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected virtual ISessionFactory SessionFactory { get; set; }
        protected virtual ISession Session { get; set; }
        protected virtual ISessionProvider SessionProvider { get; set; }

        public BaseRepo(ISessionProvider _SessionProvider)
        {
            SessionProvider = _SessionProvider;
            SessionFactory = SessionProvider.GetSessionFactory();
            Session = SessionFactory.OpenSession();
        }

        public BaseRepo()
        {
        }

        public virtual IList<T> GetAll()
        {
            IList<T> lstT = Session.QueryOver<T>().List<T>();
            return lstT;
        }

        public virtual T GetBy(Expression<Func<T, bool>> expfunc)
        {
            T T = Session.Query<T>().FirstOrDefault(expfunc);
            return T;
        }
    }
}
