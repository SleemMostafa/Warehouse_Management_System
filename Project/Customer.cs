using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Customer:Person
    {
        #region Constructor
        public Customer()
        {

        }
        public Customer(string Name, string Phone, string Address) : base(Name, Phone, Address)
        {

        }
        #endregion
    }
}
