using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class ProductType : BaseTEntity<string>
    {
        public virtual string ProductTypeName { get; set; }
    }
}
