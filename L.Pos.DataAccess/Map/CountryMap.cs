using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Id(x => x.ID).GeneratedBy.Assigned();
            Map(x => x.CountryName).Unique().Not.Nullable();
        }
    }
}
