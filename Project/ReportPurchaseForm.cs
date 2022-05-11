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
    public partial class ReportPurchaseForm : Form
    {
        private IReadOnlyList<PurchaseInvoice> purchaseInvoices;
        public ReportPurchaseForm(IReadOnlyList<PurchaseInvoice> _purchaseInvoices)
        {
            purchaseInvoices = _purchaseInvoices;
            InitializeComponent();
            if (purchaseInvoices.Count > 0)
            {
                reportPurchaseGridView1.DataSource = null;
                reportPurchaseGridView1.DataSource = purchaseInvoices;
            }
        }
        private void reportPurchaseGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (reportPurchaseGridView1.SelectedRows.Count > 0)
            {
                if (purchaseInvoices[reportPurchaseGridView1.SelectedRows[0].Index].Products.Count > 0)
                {
                    reportPurchaseGridView.DataSource = null;
                    reportPurchaseGridView.DataSource = purchaseInvoices[reportPurchaseGridView1.SelectedRows[0].Index].Products;
                    reportPurchaseGridView.Columns[0].Visible = false;
                    reportPurchaseGridView.Columns[5].Visible = false;
                    reportPurchaseGridView.Columns[6].Visible = false;
                }
                else
                {
                    MessageBox.Show("No Products");
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
            if (reportPurchaseGridView.RowCount > 0)
            {
                int hieght = reportPurchaseGridView.Height;
                reportPurchaseGridView.Height = reportPurchaseGridView.RowCount * reportPurchaseGridView.RowTemplate.Height * 2;
                bitmap = new Bitmap(reportPurchaseGridView.Width, reportPurchaseGridView.Height);
                reportPurchaseGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, reportPurchaseGridView.Width, reportPurchaseGridView.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                reportPurchaseGridView.Height = hieght;
            }
            else
            {
                MessageBox.Show("Not Found Datils");
            }
        }
        #endregion
    }
}
