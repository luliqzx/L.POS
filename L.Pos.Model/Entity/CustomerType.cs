using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class CustomerType : BaseTEntity<int>
    {
        public virtual string CustomerTypeName { get; set; }
    }
}
