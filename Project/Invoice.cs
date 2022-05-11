using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Invoice
    {
        public DateTime InvoiceDate { get; set; }
        public double Total { get; set; }
        public Invoice()
        {
            InvoiceDate = DateTime.Now;
        }
    }
}
