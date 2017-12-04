using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Address : BaseTEntity<string>
    {
        public virtual string AddressName { get; set; }
        public virtual Country Country { get; set; }
        public virtual string LineAddress { get; set; }
    }
}
