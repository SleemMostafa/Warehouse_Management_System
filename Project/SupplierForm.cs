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
    public partial class SupplierForm : Form
    {
   
        public event Action<Supplier> AddSupplier;
        IReadOnlyList<Supplier> suppliers;
        public SupplierForm(IReadOnlyList<Supplier> _suppliers)
        {
            InitializeComponent();
            suppliers = _suppliers;
            if (_suppliers.Count > 0)
            {
                SupplierDataGridView2.DataSource = null;
                SupplierDataGridView2.DataSource = _suppliers;
            }
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(SupplierBoxname.Text, SupplierTextBoxphone.Text, SupplierTextBoxAddress.Text);
            bool SupplierIsExist = false;
            supplier.Name = SupplierBoxname.Text.ToString();
            supplier.Address = SupplierTextBoxAddress.Text.ToString();
            bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(supplier.Name, "^[a-zA-Z]+$");
            bool AddressIsValid = int.TryParse(supplier.Address, out _);
            foreach (Supplier Itemsupplier in suppliers)
            {
                if (Itemsupplier.Name == supplier.Name)
                {
                    SupplierIsExist = true;
                }
            }
            int PhoneNumber;
            bool PhoneCheck = int.TryParse(SupplierTextBoxphone.Text, out PhoneNumber);
            if (PhoneCheck
                && SupplierTextBoxphone.Text[0] == '0'
                && SupplierTextBoxphone.Text[1] == '1'
                && (SupplierTextBoxphone.Text[2] == '0' || SupplierTextBoxphone.Text[2] == '5' || SupplierTextBoxphone.Text[2] == '1')
                && SupplierTextBoxphone.TextLength == 11
                && SupplierTextBoxAddress.TextLength > 3
                && SupplierBoxname.TextLength > 3 && !SupplierIsExist && !AddressIsValid && NameIsValid)
            {
                if (AddSupplier != null)
                {
                    AddSupplier(supplier);
                }
                SupplierDataGridView2.DataSource = null;
                SupplierDataGridView2.DataSource = suppliers;
            }
            else
            {
                MessageBox.Show(" Enter valid Name or Address  And Don’t Enter ExistedName ......");
            }
        }
    }
}
