﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertori
{
    class Measurement:BaseClass
    {
        public override Guid id
        {
            get { return new Guid(); }
        }
        public string name { get; set; }
    }
    
}
