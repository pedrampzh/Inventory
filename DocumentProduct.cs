using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertori
{
    class DocumentProduct:BaseClass
    {
        public override Guid id
        {
            get { return new Guid(); }
        }
        public int orginalPrice { get; set; }
        public int piece { get; set; }
        public int profit { get; set; }
        public int sellingPrice { get; set; }
        public Product product = new Product();
        private Guid productID;
        public Measurement measuerment = new Measurement();
        private Guid measurementID;
        public DocumentProduct()
        {
            productID = product.id;
            measurementID = measuerment.id;
        }
    }
}
