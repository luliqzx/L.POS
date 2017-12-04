using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Country : BaseTEntity<string>
    {
        public virtual string CountryName { get; set; }
        public virtual string Currency { get; set; }
    }
}
