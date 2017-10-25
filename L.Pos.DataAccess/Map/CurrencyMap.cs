using FluentNHibernate.Mapping;
using L.Pos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class CurrencyMap : ClassMap<Currency>
    {
        public CurrencyMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Name);
            Map(x => x.CurrencyCode);
        }
    }
}
