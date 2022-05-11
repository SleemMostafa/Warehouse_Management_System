using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SalesInvoice:Invoice
    {
        public List<ProductInfo> ProductsInfo  { get; set; }

        public static int ID = 0;
        public string Customer { get; set; }
        public SalesInvoice()
        {
            ID++;
            ProductsInfo = new List<ProductInfo>();
        }
    }
}
