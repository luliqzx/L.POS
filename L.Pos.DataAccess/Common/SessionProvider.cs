using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace L.Pos.DataAccess.Common
{
    public class SessionProvider
    {
        //private readonly string _connectionString = "";
        private  static ISessionFactory _sessionFactory;

        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        public SessionProvider()
        {
        }

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                         .Database(CreateMSSqlDbConfig())
                         .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                         .ExposeConfiguration(UpdateSchema)
                         .ExposeConfiguration(cfg => cfg.Properties.Add("use_proxy_validator", "false"))
                         .ExposeConfiguration(config =>
                         {
                             config.SetInterceptor(new SqlStatementInterceptor());
                             config.SetProperty(NHibernate.Cfg.Environment.SqlExceptionConverter,
                                 typeof(SqlExceptionConverter).AssemblyQualifiedName);
                         })
                         .BuildSessionFactory();
        }

        // Returns our database configuration
        private static MsSqlConfiguration CreateMSSqlDbConfig()
        {
            MsSqlConfiguration MsSqlConfiguration = MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("mssqlserverConn"))
            #region Debug
#if debug
                .ShowSql()
#endif
;
            #endregion
            return MsSqlConfiguration;
        }

        private static void UpdateSchema(Configuration cfg)
        {
            new SchemaUpdate(cfg)
                .Execute(false, true);
        }
    }
}
