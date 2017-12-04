using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Customer : BaseTEntity<string>
    {
        public virtual string Name { get; set; }
        public virtual CustomerType CustomerType { get; set; }
    }
}
