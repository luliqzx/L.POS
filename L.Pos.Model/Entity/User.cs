using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class User : BaseTEntity<string>
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime BirthOfDate { get; set; }
    }
}
