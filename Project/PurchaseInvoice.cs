using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class PurchaseInvoice:Invoice
    {
        public List<Product> Products { get; set; }
        public string Supplier { get; set; }
        public static int ID = 0;
        public PurchaseInvoice()
        {
            ID++;
            Products = new List<Product>();
        }
    }
}
