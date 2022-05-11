using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Store
    {
        #region Collection Of Product
        public List<Product> Products { get; set; }
        #endregion
        #region Prop
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion
        #region Constructor
        public Store(string _name, string _address)
        {
            Name = _name;
            Address = _address;
            Products = new List<Product>();

        }
        public Store()
        {
            Products = new List<Product>();
        }

        #endregion
    }

}
