using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Person
    {
        #region Member
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        #endregion
        #region Constructor
        public Person(string _name, string _phone, string _address)
        {
            Name = _name;
            Phone = _phone;
            Address = _address;
        }
        public Person()
        {

        }
        #endregion
    }
}
