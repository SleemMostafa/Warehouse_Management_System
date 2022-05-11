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
    public partial class SalesInvoiceForm : Form
    {
        public event Action<SalesInvoice> SaveSalesInvoiceEvent;
        private List<ProductInfo> productsInfo = new List<ProductInfo>();
        private List<Product> products = new List<Product>();
        private IReadOnlyList<Customer> Customers;
        public SalesInvoiceForm(IReadOnlyList<Customer> _customers,IReadOnlyList<Product> _products)
        { 

            InitializeComponent();
            foreach (Product item in _products)
            {

                products.Add(new Product() { Product_ID = item.Product_ID, Name = item.Name, Price = item.Price, Guarantee = item.Guarantee, Quantity = item.Quantity, Category = item.Category, Store = item.Store });
            }
            foreach (Product item in _products)
            {
                ProductComboBox.Items.Add(item.Name + " " + item.Store);
            }
            foreach (Customer item in _customers)
            {
                customerComboBox.Items.Add(item.Name);
            }
        }
        //view Product Info
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ProductComboBox.SelectedIndex;
            if (index != -1)
            {
                storeLabelRhite.Text = products[index].Store;
                quantityLabelRhite.Text = products[index].Quantity.ToString();
                idLabelRhite.Text = products[index].Product_ID.ToString();
                categoryLabelRhite.Text = products[index].Category;
                numericUpDown.Maximum = products[index].Quantity;
            }
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            double price;
            bool check = double.TryParse(priceSalesTextBoxprice.Text,out price);
            int index = ProductComboBox.SelectedIndex;
            
            if(index != -1 && check && price > 0 && numericUpDown.Value > 0)
            {
                int remainQuantity = products[index].Quantity - (int) (numericUpDown.Value);
                if(remainQuantity > 0)
                {
                    products[index].Quantity = remainQuantity;
                    UpdateGrid(index);

                }
                else if(remainQuantity == 0)
                {
                    UpdateGrid(index);
                    products.Remove(products[index]);
                }
                ProductComboBox.Items.Clear();
                foreach (Product item in products)
                {
                    ProductComboBox.Items.Add(item.Name);
                }
                ProductComboBox.SelectedIndex = -1;
                ProductComboBox.Text = "";
                ResetLable();
            }
            else
            {
                MessageBox.Show("Enter Valid Data........");
            }
        }
        private void UpdateGrid(int index)
        {

            productsInfo.Add(new ProductInfo() { ID = products[index].Product_ID, Quantity = (int)(numericUpDown.Value), TotalQuantityPrice = double.Parse(priceSalesTextBoxprice.Text), Name = products[index].Name, Store = products[index].Store });
            salesdataGridView.ColumnCount = 4;
            salesdataGridView.Columns[0].Name = "Name";
            salesdataGridView.Columns[1].Name = "Quantity";
            salesdataGridView.Columns[2].Name = "Store";
            salesdataGridView.Columns[3].Name = "Category";
            salesdataGridView.Rows.Add(products[index].Name, (numericUpDown.Value), products[index].Store, products[index].Category);
        }
        #region Function ResetLable
        private void ResetLable()
        {
            storeLabelRhite.Text = "";
            quantityLabelRhite.Text = "";
            idLabelRhite.Text = "";
            categoryLabelRhite.Text = "";
        }
        #endregion
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            double invoucePrice = 0;
            DialogResult result = MessageBox.Show("Are You To Sure Save","Yes / No", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (customerComboBox.SelectedIndex != -1 && salesdataGridView.Rows.Count > 0)
                {
                    SalesInvoice salesInvoice = new SalesInvoice() { Customer = customerComboBox.Text };
                    if (SaveSalesInvoiceEvent != null)
                    {
                        foreach (ProductInfo item in productsInfo)
                        {
                            salesInvoice.ProductsInfo.Add(item);
                            invoucePrice += item.TotalQuantityPrice;
                        }
                        salesInvoice.Total = invoucePrice;
                        productsInfo.Clear();
                        SaveSalesInvoiceEvent(salesInvoice);
                        salesdataGridView.Rows.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Product Or Customer...........");
                }
            }
        }
    }
}
