using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model
{
    public class User : BaseTEntity<string>
    {
        public virtual string Name { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}
