using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        #region Member
        public static int Product_IDStatic = 0;
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Guarantee { get; set; }
        public string Category { get; set; }
        public string Store { get; set; }
        //public Category category { get; set; }
   
        #endregion
        #region Constructor
        public Product(string _name, double _price,int _Quantity, int _Guarantee/*,Category _catogory*/)
        {
            Name = _name;
            Price = _price;
            Quantity = _Quantity;
            Guarantee = _Guarantee;
            //category = _catogory;
            Product_IDStatic++;

        }
        public Product(string _name, double _price, int _Quantity, int _Guarantee, string _coteg )
        {
            Name = _name;
            Price = _price;
            Quantity = _Quantity;
            Guarantee = _Guarantee;
            Category = _coteg;
            Product_IDStatic++;
        }
        public Product()
        {
            //category = new Category();
            Product_IDStatic++;
        }
        #endregion
    }
}
