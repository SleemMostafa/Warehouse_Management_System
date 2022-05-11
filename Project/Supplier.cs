using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Supplier:Person
    {
        #region Constructor
        public Supplier()
        {

        }
        public Supplier(string Name, string Phone, string Address) : base(Name, Phone, Address)
        {

        }
        #endregion
    }
}
