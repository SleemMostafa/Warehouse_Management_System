using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CustomerForm : Form
    {
        public event Action<Customer> AddCustomer;
        IReadOnlyList<Customer> customers;
        public CustomerForm(IReadOnlyList<Customer> _customers)
        {
            InitializeComponent();
            customers = _customers;
            if (_customers.Count > 0)
            {
                CustomerDataGridView2.DataSource = null;
                CustomerDataGridView2.DataSource = _customers;
            }
        }
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(CustomerBoxname.Text, CustomerTextBoxphone.Text, CustomerTextBoxAddress.Text);
            bool CustomerIsExist = false;
            customer.Name = CustomerBoxname.Text.ToString();
            customer.Address = CustomerTextBoxAddress.Text.ToString();
            bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(customer.Name, "^[a-zA-Z]+$");
            bool AddressIsValid = int.TryParse(customer.Address, out _);
            foreach (Customer Itemcustom in customers)
            {
                if (Itemcustom.Name == customer.Name)
                {
                    CustomerIsExist = true;
                }
            }
            int PhoneNumber;
            bool PhoneCheck = int.TryParse(CustomerTextBoxphone.Text, out PhoneNumber);
            if (PhoneCheck
                && CustomerTextBoxphone.Text[0] == '0'
                && CustomerTextBoxphone.Text[1] == '1'
                && (CustomerTextBoxphone.Text[2] == '0' || CustomerTextBoxphone.Text[2] == '5' || CustomerTextBoxphone.Text[2] == '1' || CustomerTextBoxphone.Text[2] == '2')
                && CustomerTextBoxphone.TextLength == 11
                && CustomerTextBoxAddress.TextLength > 3
                && CustomerBoxname.TextLength > 3 && !CustomerIsExist && !AddressIsValid && NameIsValid)
            {

                if (AddCustomer != null)
                {
                    AddCustomer(customer);
                }
                CustomerDataGridView2.DataSource = null;
                CustomerDataGridView2.DataSource = customers;
            }
            else
            {
                MessageBox.Show(" Enter valid Name or Address  And Don’t Enter ExistedName ......");

            }
        }
    }
}
