using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.ID).GeneratedBy.Assigned();
            Map(x => x.Name);
            References(x => x.CustomerType).Column("CustomerTypeID").Cascade.None();
        }
    }
}
