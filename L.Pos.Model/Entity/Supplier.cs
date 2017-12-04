using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Supplier : BaseTEntity<string>
    {
        public virtual string SupplierName { get; set; }
    }
}
