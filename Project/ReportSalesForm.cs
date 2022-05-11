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
    public partial class ReportSalesForm : Form
    {
        private IReadOnlyList<SalesInvoice> salesInvoices;
        public ReportSalesForm(IReadOnlyList<SalesInvoice> _salesInvoices)
        {
            InitializeComponent();
            salesInvoices = _salesInvoices;
            if (salesInvoices.Count > 0)
            {
                SalesInvoiceGridView.DataSource = null;
                SalesInvoiceGridView.DataSource = _salesInvoices;
            }
        }
        private void SalesInvoiceGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SalesInvoiceGridView.SelectedRows.Count > 0)
            {
                ProductsGridView.DataSource = null;
                ProductsGridView.DataSource = salesInvoices[SalesInvoiceGridView.SelectedRows[0].Index].ProductsInfo;
                ProductsGridView.Columns[1].Visible = false;
            }
        }
        #region Print Report Event
        Bitmap bitmap;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (ProductsGridView.RowCount > 0)
            {
                int hieght = ProductsGridView.Height;
                ProductsGridView.Height = ProductsGridView.RowCount * ProductsGridView.RowTemplate.Height * 2;
                bitmap = new Bitmap(ProductsGridView.Width, ProductsGridView.Height);
                ProductsGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, ProductsGridView.Width, ProductsGridView.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                ProductsGridView.Height = hieght;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        #endregion
    }
}
