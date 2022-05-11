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
    public partial class MainForm : Form
    {
        int move, movex, movey;
        private List<Category> categories = new List<Category>();
        private List<Product> products = new List<Product>();
        private List<PurchaseInvoice> purchaseInvoices = new List<PurchaseInvoice>();
        private List<SalesInvoice> salesInvoice = new List<SalesInvoice>();
        private List<Customer> customers = new List<Customer>();
        private List<Supplier> suppliers = new List<Supplier>();
        private List<Store> stores = new List<Store>();
        private Login login = new Login();
        public MainForm(Login log)
        {
            InitializeComponent();
            login = log;
        }
        #region EditProduct
        private void EditProduct(string OldProductNameValue, string NewProductNameValue)
        {
            foreach (Product product in products)
            {
                if (product.Name == OldProductNameValue)
                {
                    product.Name = NewProductNameValue;
                    MessageBox.Show("Done..." + NewProductNameValue);
                }
            }
        }
        #endregion
        #region AddCategory
        private void AddCategory(Category obj)
        {
            categories.Add(obj);
        }
        #endregion
        #region AddStore
        private void AddStore(Store obj)
        {
            stores.Add(obj);
            //MessageBox.Show(stores[0].Name);
        }
        #endregion
        #region Edit Category
        private void EditCategory(string OldCategoryName, string NewCategoryName)
        {
            foreach (Category item in categories)
            {
                if (item.Name == OldCategoryName)
                {
                    item.Name = NewCategoryName;
                }
            }
            foreach (Product item in products)
            {
                if (item.Category == OldCategoryName)
                {
                    item.Category = NewCategoryName;
                }
            }
        }

        #endregion
        #region Edit Store
        private void EditStore(string OldName, string NewStoreName, string NewStoreAddress)
        {
            foreach (Store item in stores)
            {
                if (item.Name == OldName)
                {
                    item.Name = NewStoreName;
                    item.Address = NewStoreAddress;
                }
            }
            foreach (Product item in products)
            {
                if (item.Store == OldName)
                {
                    item.Store = NewStoreName;
                }
            }
        }
        #endregion
        #region AddProduct
        private void AddProduct(Product obj)
        {
            products.Add(obj);
            //MessageBox.Show(obj.Product_ID.ToString());
            foreach (Store item in stores)
            {
                if(item.Name == obj.Store)
                {
                    item.Products.Add(obj);
                }
            }
            foreach (Category item in categories)
            {
                if (item.Name == obj.Category)
                {
                    item.Products.Add(obj);
                }
            }
        }
        #endregion
        #region AddPpurchaseInvoices
        private void AddPpurchaseInvoices(PurchaseInvoice obj)
        {
            purchaseInvoices.Add(obj);
            //MessageBox.Show(PurchaseInvoice.ID.ToString());
            MessageBox.Show("Done.....");
            foreach (Product item in obj.Products)
            {
                foreach (Product myProduct in products)
                {
                    if(item.Name== myProduct.Name)
                    {
                        myProduct.Price = item.Price;
                        myProduct.Guarantee = item.Guarantee;
                        myProduct.Quantity += item.Quantity;
                    }
                }
            }
        }
        #endregion
        #region AddSupplier
        private void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }
        #endregion
        #region AddCustomer
        private void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        #endregion
        #region AddSalesInvoice
        private void AddSalesInvoice(SalesInvoice _salesInvoice)
        {
            salesInvoice.Add(_salesInvoice);
            foreach (ProductInfo item in _salesInvoice.ProductsInfo)
            {
                foreach (Product myProduct in products)
                {
                    if (item.Name == myProduct.Name)
                    {
                        myProduct.Quantity -= item.Quantity;
                    }
                }
                MessageBox.Show(item.Name);
            }

            MessageBox.Show("Save Success");
        }
        #endregion
        #region HeadBar
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Close();
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; 
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }
        private void storeBtnOpen_Click(object sender, EventArgs e)
        {
            Stores store = new Stores(stores);
            store.MdiParent = this;
            store.Show();
            store.Dock = DockStyle.Fill;
            store.AddStoreEvent += AddStore;
            store.EditStoreEvent += EditStore;
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productform = new ProductsForm(products,categories,stores);
            productform.MdiParent = this;
            productform.Show();
            productform.Dock = DockStyle.Fill;
            productform.AddProductEvent += AddProduct;
            productform.EditProductEvent += EditProduct;

        }
        private void categorybtnForm_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(categories);
            categoryForm.MdiParent = this;
            categoryForm.Show();
            categoryForm.Dock = DockStyle.Fill;
            categoryForm.AddCategoryEvent += AddCategory;
            categoryForm.EditCategoryEvent += EditCategory;
        }
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm(customers);
            customer.MdiParent = this;
            customer.Show();
            customer.Dock = DockStyle.Fill;
            customer.AddCustomer += AddCustomer;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            SupplierForm Supplierform = new SupplierForm(suppliers);
            Supplierform.MdiParent = this;
            Supplierform.Show();
            Supplierform.Dock = DockStyle.Fill;
            Supplierform.AddSupplier += AddSupplier;
        }
        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm PurchaseInvoice = new PurchaseInvoiceForm(suppliers,products);
            PurchaseInvoice.MdiParent = this;
            PurchaseInvoice.Show();
            PurchaseInvoice.Dock = DockStyle.Fill;
            PurchaseInvoice.AddPruchaseInvoiceEvent += AddPpurchaseInvoices;
        }

        private void btnGoFormSales_Click(object sender, EventArgs e)
        {
            SalesInvoiceForm salesInvoice = new SalesInvoiceForm(customers,products);
            salesInvoice.MdiParent = this;
            salesInvoice.Show();
            salesInvoice.Dock = DockStyle.Fill;
            salesInvoice.SaveSalesInvoiceEvent += AddSalesInvoice;

        }

        private void btnReportStore_Click(object sender, EventArgs e)
        {
            ReportStoreForm reportStore = new ReportStoreForm(products,categories,stores);
            reportStore.MdiParent = this;
            reportStore.Show();
            reportStore.Dock = DockStyle.Fill;
        }

        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {
            ReportPurchaseForm reportPurchase = new ReportPurchaseForm(purchaseInvoices);
            reportPurchase.MdiParent = this;
            reportPurchase.Show();
            reportPurchase.Dock = DockStyle.Fill;
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ReportSalesForm reportSales = new ReportSalesForm(salesInvoice);
            reportSales.MdiParent = this;
            reportSales.Show();
            reportSales.Dock = DockStyle.Fill;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);
            }
        }
        #endregion
    }
}
