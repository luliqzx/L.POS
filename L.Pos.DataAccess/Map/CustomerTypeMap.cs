using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class CustomerTypeMap : ClassMap<CustomerType>
    {
        public CustomerTypeMap()
        {
            Id(x => x.ID).GeneratedBy.Assigned();
            Map(x => x.CustomerTypeName).Unique().Not.Nullable().Length(25);
        }
    }
}
