namespace Project
{
    partial class SalesInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSaveProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSaveInvoice = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.salesdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nameProduct = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.priceSalesInvoice = new Guna.UI.WinForms.GunaLabel();
            this.priceSalesTextBoxprice = new Guna.UI.WinForms.GunaLineTextBox();
            this.storeLabel = new Guna.UI.WinForms.GunaLabel();
            this.quantityLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.categoryLabelRhite = new Guna.UI.WinForms.GunaLabel();
            this.idLabelRhite = new Guna.UI.WinForms.GunaLabel();
            this.quantityLabelRhite = new Guna.UI.WinForms.GunaLabel();
            this.storeLabelRhite = new Guna.UI.WinForms.GunaLabel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.salesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.AnimationHoverSpeed = 0.07F;
            this.btnSaveProduct.AnimationSpeed = 0.03F;
            this.btnSaveProduct.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveProduct.BorderColor = System.Drawing.Color.Black;
            this.btnSaveProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSaveProduct.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSaveProduct.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.CheckedImage")));
            this.btnSaveProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSaveProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveProduct.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.Image")));
            this.btnSaveProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveProduct.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSaveProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveProduct.Location = new System.Drawing.Point(216, 398);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveProduct.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.OnHoverImage = null;
            this.btnSaveProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveProduct.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveProduct.Size = new System.Drawing.Size(215, 42);
            this.btnSaveProduct.TabIndex = 60;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.AnimationHoverSpeed = 0.07F;
            this.btnSaveInvoice.AnimationSpeed = 0.03F;
            this.btnSaveInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnSaveInvoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSaveInvoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSaveInvoice.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSaveInvoice.CheckedImage")));
            this.btnSaveInvoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSaveInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInvoice.Image")));
            this.btnSaveInvoice.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSaveInvoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveInvoice.Location = new System.Drawing.Point(785, 180);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSaveInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.OnHoverImage = null;
            this.btnSaveInvoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSaveInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveInvoice.Size = new System.Drawing.Size(160, 160);
            this.btnSaveInvoice.TabIndex = 59;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // salesdataGridView
            // 
            this.salesdataGridView.AllowUserToAddRows = false;
            this.salesdataGridView.AllowUserToDeleteRows = false;
            this.salesdataGridView.AllowUserToResizeColumns = false;
            this.salesdataGridView.AllowUserToResizeRows = false;
            this.salesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.salesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.salesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesdataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.salesdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salesdataGridView.Location = new System.Drawing.Point(0, 496);
            this.salesdataGridView.Name = "salesdataGridView";
            this.salesdataGridView.ReadOnly = true;
            this.salesdataGridView.RowHeadersWidth = 51;
            this.salesdataGridView.Size = new System.Drawing.Size(1000, 104);
            this.salesdataGridView.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(637, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Product Information";
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.nameProduct.Location = new System.Drawing.Point(61, 142);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(69, 21);
            this.nameProduct.TabIndex = 49;
            this.nameProduct.Text = "Custmer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sales Invoice";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(207, 142);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(215, 26);
            this.customerComboBox.TabIndex = 61;
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(207, 206);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(215, 26);
            this.ProductComboBox.TabIndex = 63;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(61, 206);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 21);
            this.gunaLabel1.TabIndex = 62;
            this.gunaLabel1.Text = "Product";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel5.Location = new System.Drawing.Point(61, 266);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(70, 21);
            this.gunaLabel5.TabIndex = 53;
            this.gunaLabel5.Text = "Quantity";
            // 
            // priceSalesInvoice
            // 
            this.priceSalesInvoice.AutoSize = true;
            this.priceSalesInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceSalesInvoice.ForeColor = System.Drawing.SystemColors.Control;
            this.priceSalesInvoice.Location = new System.Drawing.Point(61, 322);
            this.priceSalesInvoice.Name = "priceSalesInvoice";
            this.priceSalesInvoice.Size = new System.Drawing.Size(117, 21);
            this.priceSalesInvoice.TabIndex = 66;
            this.priceSalesInvoice.Text = "Collection Price";
            // 
            // priceSalesTextBoxprice
            // 
            this.priceSalesTextBoxprice.BackColor = System.Drawing.Color.White;
            this.priceSalesTextBoxprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceSalesTextBoxprice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.priceSalesTextBoxprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceSalesTextBoxprice.LineColor = System.Drawing.Color.Gainsboro;
            this.priceSalesTextBoxprice.Location = new System.Drawing.Point(207, 322);
            this.priceSalesTextBoxprice.Name = "priceSalesTextBoxprice";
            this.priceSalesTextBoxprice.PasswordChar = '\0';
            this.priceSalesTextBoxprice.SelectedText = "";
            this.priceSalesTextBoxprice.Size = new System.Drawing.Size(215, 30);
            this.priceSalesTextBoxprice.TabIndex = 65;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.storeLabel.Location = new System.Drawing.Point(468, 142);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(46, 18);
            this.storeLabel.TabIndex = 67;
            this.storeLabel.Text = "Store";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.quantityLabel.Location = new System.Drawing.Point(468, 206);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(64, 18);
            this.quantityLabel.TabIndex = 68;
            this.quantityLabel.Text = "Quantity";
            // 
            // gunaLabel
            // 
            this.gunaLabel.AutoSize = true;
            this.gunaLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel.Location = new System.Drawing.Point(468, 266);
            this.gunaLabel.Name = "gunaLabel";
            this.gunaLabel.Size = new System.Drawing.Size(23, 18);
            this.gunaLabel.TabIndex = 69;
            this.gunaLabel.Text = "ID";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel6.Location = new System.Drawing.Point(468, 322);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(72, 18);
            this.gunaLabel6.TabIndex = 70;
            this.gunaLabel6.Text = "Category";
            // 
            // categoryLabelRhite
            // 
            this.categoryLabelRhite.AutoSize = true;
            this.categoryLabelRhite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabelRhite.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryLabelRhite.Location = new System.Drawing.Point(638, 324);
            this.categoryLabelRhite.Name = "categoryLabelRhite";
            this.categoryLabelRhite.Size = new System.Drawing.Size(0, 18);
            this.categoryLabelRhite.TabIndex = 74;
            // 
            // idLabelRhite
            // 
            this.idLabelRhite.AutoSize = true;
            this.idLabelRhite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelRhite.ForeColor = System.Drawing.SystemColors.Control;
            this.idLabelRhite.Location = new System.Drawing.Point(638, 268);
            this.idLabelRhite.Name = "idLabelRhite";
            this.idLabelRhite.Size = new System.Drawing.Size(0, 18);
            this.idLabelRhite.TabIndex = 73;
            // 
            // quantityLabelRhite
            // 
            this.quantityLabelRhite.AutoSize = true;
            this.quantityLabelRhite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabelRhite.ForeColor = System.Drawing.SystemColors.Control;
            this.quantityLabelRhite.Location = new System.Drawing.Point(638, 208);
            this.quantityLabelRhite.Name = "quantityLabelRhite";
            this.quantityLabelRhite.Size = new System.Drawing.Size(0, 18);
            this.quantityLabelRhite.TabIndex = 72;
            // 
            // storeLabelRhite
            // 
            this.storeLabelRhite.AutoSize = true;
            this.storeLabelRhite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabelRhite.ForeColor = System.Drawing.SystemColors.Control;
            this.storeLabelRhite.Location = new System.Drawing.Point(638, 144);
            this.storeLabelRhite.Name = "storeLabelRhite";
            this.storeLabelRhite.Size = new System.Drawing.Size(0, 18);
            this.storeLabelRhite.TabIndex = 71;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(207, 261);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(215, 26);
            this.numericUpDown.TabIndex = 76;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SalesInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.categoryLabelRhite);
            this.Controls.Add(this.idLabelRhite);
            this.Controls.Add(this.quantityLabelRhite);
            this.Controls.Add(this.storeLabelRhite);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.priceSalesInvoice);
            this.Controls.Add(this.priceSalesTextBoxprice);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.salesdataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesInvoiceForm";
            this.Text = "SalesInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.salesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnSaveProduct;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnSaveInvoice;
        private System.Windows.Forms.DataGridView salesdataGridView;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel nameProduct;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel priceSalesInvoice;
        private Guna.UI.WinForms.GunaLineTextBox priceSalesTextBoxprice;
        private Guna.UI.WinForms.GunaLabel storeLabel;
        private Guna.UI.WinForms.GunaLabel quantityLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel categoryLabelRhite;
        private Guna.UI.WinForms.GunaLabel idLabelRhite;
        private Guna.UI.WinForms.GunaLabel quantityLabelRhite;
        private Guna.UI.WinForms.GunaLabel storeLabelRhite;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}