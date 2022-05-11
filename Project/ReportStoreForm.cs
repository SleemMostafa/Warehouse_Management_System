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
    public partial class ReportStoreForm : Form
    {
        private IReadOnlyList<Product> products;
        private IReadOnlyList<Category> categories;
        private IReadOnlyList<Store> stores;
        public ReportStoreForm(IReadOnlyList<Product> _products, IReadOnlyList<Category> _categories, IReadOnlyList<Store> _stores)
        {
            InitializeComponent();
            products = _products;
            categories = _categories;
            stores = _stores;
            if (_categories.Count > 0 && _products.Count > 0 || _stores.Count > 0)
            {
                foreach (Store item in stores)
                {
                    reportStoreComBox.Items.Add(item.Name);
                }
            }
        }   
        private void reportStoreComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportStoreComBox.SelectedIndex != -1)
            {
                List<Product> itr = new List<Product>();
                foreach (Product item in products)
                {
                    if (reportStoreComBox.Text == item.Store)
                     {
                        itr.Add(item);
                     }
                }
                if (itr.Count > 0)
                {
                    reportStoredataGridView.DataSource = itr;
                }
                else
                {
                    reportStoredataGridView.DataSource = null;
                }
            }

        }
        #region Print Report Event
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (reportStoredataGridView.RowCount > 0)
            {
                int hieght = reportStoredataGridView.Height;
                reportStoredataGridView.Height = reportStoredataGridView.RowCount * reportStoredataGridView.RowTemplate.Height * 2;
                bitmap = new Bitmap(reportStoredataGridView.Width, reportStoredataGridView.Height);
                reportStoredataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, reportStoredataGridView.Width, reportStoredataGridView.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                reportStoredataGridView.Height = hieght;
            }
        }
        #endregion
    }
}
