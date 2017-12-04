using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Company : BaseTEntity<string>
    {
        public virtual string CompanyName { get; set; }
        public virtual Country Country { get; set; }
    }
}
