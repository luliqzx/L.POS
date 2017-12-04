using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class TEntity<TID>
    {
        public virtual TID ID { get; set; }
    }
}
