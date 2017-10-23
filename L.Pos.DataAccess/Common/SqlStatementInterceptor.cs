﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Common
{
    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
            string qry = sql.ToString();
            //Trace.WriteLine(qry);
            return sql;
        }
    }
}
