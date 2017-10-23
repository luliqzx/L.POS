﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model
{
    public class BaseTEntity<TID> : TEntity<TID>
    {
        public virtual string CreateBy { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateTerminal { get; set; }
        public virtual string UpdateBy { get; set; }
        public virtual DateTime? UpdateDate { get; set; }
        public virtual string UpdateTerminal { get; set; }
        public virtual int? Version { get; set; }
    }
}
