using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Category
    {
        #region Member
        public string Name { get; set; }
        #endregion
        #region Collection Of Products
        public List<Product> Products { get; set; }
        #endregion
        #region Constructor
        public Category()
        {
            Products = new List<Product>();
        }
        public Category(string _name)
        {
            Name = _name;
            Products = new List<Product>();
        }
        #endregion
    }
}
