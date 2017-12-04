using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            Id(x => x.ID).GeneratedBy.Assigned();
            Map(x => x.LineAddress);
            References(x => x.Country).Column("CountryID");
            Map(x => x.AddressName).Not.Nullable();
        }
    }
}
