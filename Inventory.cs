using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertori
{
    class Inventory:BaseClass
    {
        public override Guid id
        {
            get { return new Guid(); }
        }
        public string nameinventori{set; get; }
        public string adress{set; get;}
        public string datein{set; get;}
        public string dateoute{set; get;}
        List<DocumentProduct> document ;
    }
}
