using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class CustomerAddress
    {
        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                CustomerAddress entity = obj as CustomerAddress;
                if (entity.Customer == Customer && entity.Address == Address)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (Customer.ID + "|" + Address.ID).GetHashCode();
            return i;
        }
    }
}
