using FluentNHibernate.Mapping;
using L.Pos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("TUser");
            Id(x => x.ID).GeneratedBy.Assigned();
            //Map(x => x.Name).Length(100).Not.Nullable();
            Map(x => x.Username).Unique().Length(25).Not.Nullable();
            Map(x => x.Password).Length(int.MaxValue);
        }
    }
}
