using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Privilege : BaseTEntity<string>
    {
        public virtual string PrivilegeName { get; set; }
    }
}
