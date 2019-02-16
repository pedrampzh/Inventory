using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertori 
{
    public abstract class BaseClass
    {
        public abstract Guid id { get; }
        public int code { get; set; }
    }
}
