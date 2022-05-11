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
    public partial class ProductsForm : Form
    {
        public event Action<string, string> EditProductEvent;
        public event Action<Product> AddProductEvent;
        private IReadOnlyList<Product> products;
        private IReadOnlyList<Category> categories;
        private IReadOnlyList<Store> stores;
        public ProductsForm(IReadOnlyList<Product> _products,IReadOnlyList<Category> _categories, IReadOnlyList<Store> _stores)
        {
            InitializeComponent();
            products = _products;
            categories = _categories;
            stores = _stores;

            if (_products.Count > 0)
            {
                productDataGridView.DataSource = null;
                productDataGridView.DataSource = _products;
            }
            if (_categories.Count > 0)
            {
                foreach (Category item in categories)
                {
                    categoryComBoxCategort.Items.Add(item.Name);
                }
            }
            if (_stores.Count > 0)
            {
                foreach (Store item in stores)
                {
                    storeComBoxCategort.Items.Add(item.Name);
                }
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(productTextBoxname.Text, "^[a-zA-Z]+$");
            bool ProductIsExist = false;
            if (productTextBoxname.Text.Length > 0 
                && categoryComBoxCategort.SelectedIndex != -1 
                && storeComBoxCategort.SelectedIndex != -1 && NameIsValid)
            {
                foreach (Product productItem in products)
                {
                    if (productItem.Name == productTextBoxname.Text)
                    {
                        ProductIsExist = true;
                    }
                }
                if (!ProductIsExist)
                {
                    Product product = new Product();
                    product.Name = productTextBoxname.Text;
                    product.Category = categoryComBoxCategort.SelectedItem.ToString();
                    product.Store = storeComBoxCategort.SelectedItem.ToString();
                    product.Product_ID = Product.Product_IDStatic;
                    if (AddProductEvent != null)
                    {
                        AddProductEvent(product);
                    }
                    CleanFiled();
                }
                else
                {
                    ProductIsExist = false;
                    MessageBox.Show("Product Is Exist...");
                }


                productDataGridView.DataSource = null;

                productDataGridView.DataSource = products;
            }
            else
            {
                MessageBox.Show("Enter Valid Data.............");
            }
        }
        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            bool ProductIsExist = false;
            if (productDataGridView.SelectedRows.Count == 1)
                {
                bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(productTextBoxname.Text, "^[a-zA-Z]+$");
                string OldProductNameValue = productDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    foreach (Product product in products)
                    {
                        if (product.Name == productTextBoxname.Text)
                        {
                            ProductIsExist = true;
                        }
                    }
                    if (!ProductIsExist)
                    {
                        if (EditProductEvent != null && NameIsValid)
                        {
                            EditProductEvent(OldProductNameValue, productTextBoxname.Text);
                            storeComBoxCategort.Enabled = true;
                            categoryComBoxCategort.Enabled = true;
                        }
                        else
                        {
                        MessageBox.Show("Enter Valid Data.......");
                        }
                        CleanFiled();
                    }
                    else
                    {
                        ProductIsExist = false;
                        MessageBox.Show("Product Is Exist...");
                        CleanFiled();
                    }
                productDataGridView.DataSource = null;

                    productDataGridView.DataSource = products;
                }
                else
                {
                    MessageBox.Show("You Must Select From List First");
                }
        }
        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (productDataGridView.SelectedRows.Count > 0)
            {
                productTextBoxname.Text = productDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                storeComBoxCategort.Enabled = false;
                categoryComBoxCategort.Enabled = false; 
            }
        }
        #region CleanFileds
        private void CleanFiled()
        {
            productTextBoxname.Text = "";
            categoryComBoxCategort.SelectedIndex = -1;
            categoryComBoxCategort.Text = "";
            storeComBoxCategort.SelectedIndex = -1;
            storeComBoxCategort.Text = "";
        }
        #endregion
    }

}
