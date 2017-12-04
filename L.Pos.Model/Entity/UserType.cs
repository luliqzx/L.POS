using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class UserType : BaseTEntity<string>
    {
        public virtual string UserTypeName { get; set; }
    }
}
