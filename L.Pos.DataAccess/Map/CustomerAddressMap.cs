using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.DataAccess.Map
{
    public class CustomerAddressMap : ClassMap<CustomerAddress>
    {
        public CustomerAddressMap()
        {
            CompositeId().KeyReference(x => x.Customer, "CustomerID")
                .KeyReference(x => x.Address, "AddressID");
        }
    }
}
