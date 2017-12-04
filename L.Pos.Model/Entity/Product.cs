using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Product
    {
        public virtual string ProductName { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
