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
    public partial class PurchaseInvoiceForm : Form
    {
        public event Action<PurchaseInvoice> AddPruchaseInvoiceEvent;
        private PurchaseInvoice pruchaseInvoice;
        private List<Product> products = new List<Product>();
        double TotalPriceInInVoice;
        private IReadOnlyList<Product> productsForView;
        public PurchaseInvoiceForm(IReadOnlyList<Supplier> suppliers, IReadOnlyList<Product> _productsForView)
        {
            TotalPriceInInVoice = 0;
            InitializeComponent();
            productsForView = _productsForView;
            foreach (Product item in productsForView)
            {
                productsComBoxPurchase.Items.Add(item.Name);
            }
            
            foreach (Supplier item in suppliers)
            {
                suplierComboBox.Items.Add(item.Name);
            }
        }
        private void btnAddProductInvoice_Click(object sender, EventArgs e)
        {
            double priceTest;
            int QuantityTest;
            int GuaranteeTest;
            bool flagePrice = double.TryParse(purchaseTextBoxprice.Text, out priceTest);
            bool flageQuantity = int.TryParse(purchaseTextBoxQuantity.Text, out QuantityTest);
            bool flageGuarantee = int.TryParse(purchaseTextBoxGuarantee.Text, out GuaranteeTest);

            if (flagePrice &&
                flageQuantity &&
                priceTest > 0 &&
                QuantityTest > 0 &&
                GuaranteeTest > 0 &&
                flageGuarantee &&
                productsComBoxPurchase.SelectedIndex != -1 
                )
            {
                Product product = new Product();
                product.Name = productsComBoxPurchase.SelectedItem.ToString();
                product.Price = priceTest;
                product.Guarantee = GuaranteeTest;
                product.Quantity = QuantityTest;
                TotalPriceInInVoice += priceTest * QuantityTest;
                products.Add(product);
                CleanFileds();
            }
            else
            {
                MessageBox.Show("Insert Valid Data.............");
            }
        }
        private void btnAddInvoiceAll_Click(object sender, EventArgs e)
        {

            if (products.Count > 0 &&
                suplierComboBox.SelectedIndex != -1 &&
                AddPruchaseInvoiceEvent != null)
            {
                pruchaseInvoice = new PurchaseInvoice();
                pruchaseInvoice.Supplier = suplierComboBox.SelectedItem.ToString();
                foreach (Product product in products)
                {
                    pruchaseInvoice.Products.Add(product);
                }
                pruchaseInvoice.Total = TotalPriceInInVoice;
                AddPruchaseInvoiceEvent(pruchaseInvoice);
                pruchasedataGridView.DataSource = null;
                products.Clear();
                suplierComboBox.SelectedIndex = -1;
                TotalPriceInInVoice = 0;
            }
            else
            {
                MessageBox.Show("Insert Data..............");
            }
        }
        #region CleanFileds
        private void CleanFileds()
        {
            pruchasedataGridView.DataSource = null;
            pruchasedataGridView.DataSource = products;
            pruchasedataGridView.Columns[0].Visible = false;
            pruchasedataGridView.Columns[5].Visible = false;
            pruchasedataGridView.Columns[6].Visible = false;
            purchaseTextBoxQuantity.Text = "";
            purchaseTextBoxGuarantee.Text = "";
            purchaseTextBoxprice.Text = "";
            productsComBoxPurchase.SelectedIndex = -1;
            productsComBoxPurchase.Text = "";
        }
        #endregion
    }
}