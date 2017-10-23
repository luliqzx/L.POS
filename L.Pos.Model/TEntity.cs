using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model
{
    public class TEntity<TID>
    {
        public virtual TID ID { get; set; }
    }
}
