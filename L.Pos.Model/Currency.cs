﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model
{
    public class Currency
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string CurrencyCode { get; set; }
    }
}
