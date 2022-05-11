namespace Project
{
    partial class PurchaseInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInvoiceForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.suplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierLabl = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.productsComBoxPurchase = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.priceProduct = new Guna.UI.WinForms.GunaLabel();
            this.nameProduct = new Guna.UI.WinForms.GunaLabel();
            this.purchaseTextBoxGuarantee = new Guna.UI.WinForms.GunaLineTextBox();
            this.purchaseTextBoxQuantity = new Guna.UI.WinForms.GunaLineTextBox();
            this.purchaseTextBoxprice = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pruchasedataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddProductInvoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddInvoiceAll = new Guna.UI.WinForms.GunaAdvenceTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pruchasedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // suplierComboBox
            // 
            this.suplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suplierComboBox.FormattingEnabled = true;
            this.suplierComboBox.Location = new System.Drawing.Point(585, 128);
            this.suplierComboBox.Name = "suplierComboBox";
            this.suplierComboBox.Size = new System.Drawing.Size(230, 28);
            this.suplierComboBox.TabIndex = 0;
            // 
            // supplierLabl
            // 
            this.supplierLabl.AutoSize = true;
            this.supplierLabl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabl.ForeColor = System.Drawing.SystemColors.Control;
            this.supplierLabl.Location = new System.Drawing.Point(473, 128);
            this.supplierLabl.Name = "supplierLabl";
            this.supplierLabl.Size = new System.Drawing.Size(66, 18);
            this.supplierLabl.TabIndex = 1;
            this.supplierLabl.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "PurchaseInvoice";
            // 
            // productsComBoxPurchase
            // 
            this.productsComBoxPurchase.BackColor = System.Drawing.Color.Transparent;
            this.productsComBoxPurchase.BaseColor = System.Drawing.Color.White;
            this.productsComBoxPurchase.BorderColor = System.Drawing.Color.Silver;
            this.productsComBoxPurchase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productsComBoxPurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productsComBoxPurchase.FocusedColor = System.Drawing.Color.Empty;
            this.productsComBoxPurchase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productsComBoxPurchase.ForeColor = System.Drawing.Color.Black;
            this.productsComBoxPurchase.FormattingEnabled = true;
            this.productsComBoxPurchase.Location = new System.Drawing.Point(206, 125);
            this.productsComBoxPurchase.Name = "productsComBoxPurchase";
            this.productsComBoxPurchase.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productsComBoxPurchase.OnHoverItemForeColor = System.Drawing.Color.White;
            this.productsComBoxPurchase.Size = new System.Drawing.Size(215, 26);
            this.productsComBoxPurchase.TabIndex = 35;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(60, 296);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(82, 21);
            this.gunaLabel4.TabIndex = 33;
            this.gunaLabel4.Text = "Guarantee";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(60, 239);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(70, 21);
            this.gunaLabel3.TabIndex = 32;
            this.gunaLabel3.Text = "Quantity";
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSize = true;
            this.priceProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.priceProduct.Location = new System.Drawing.Point(60, 183);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(77, 21);
            this.priceProduct.TabIndex = 31;
            this.priceProduct.Text = "Unit Price";
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.nameProduct.Location = new System.Drawing.Point(60, 128);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(71, 21);
            this.nameProduct.TabIndex = 30;
            this.nameProduct.Text = "Products";
            // 
            // purchaseTextBoxGuarantee
            // 
            this.purchaseTextBoxGuarantee.BackColor = System.Drawing.Color.White;
            this.purchaseTextBoxGuarantee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchaseTextBoxGuarantee.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchaseTextBoxGuarantee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purchaseTextBoxGuarantee.LineColor = System.Drawing.Color.Gainsboro;
            this.purchaseTextBoxGuarantee.Location = new System.Drawing.Point(206, 296);
            this.purchaseTextBoxGuarantee.Name = "purchaseTextBoxGuarantee";
            this.purchaseTextBoxGuarantee.PasswordChar = '\0';
            this.purchaseTextBoxGuarantee.SelectedText = "";
            this.purchaseTextBoxGuarantee.Size = new System.Drawing.Size(215, 30);
            this.purchaseTextBoxGuarantee.TabIndex = 29;
            // 
            // purchaseTextBoxQuantity
            // 
            this.purchaseTextBoxQuantity.BackColor = System.Drawing.Color.White;
            this.purchaseTextBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchaseTextBoxQuantity.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchaseTextBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purchaseTextBoxQuantity.LineColor = System.Drawing.Color.Gainsboro;
            this.purchaseTextBoxQuantity.Location = new System.Drawing.Point(206, 239);
            this.purchaseTextBoxQuantity.Name = "purchaseTextBoxQuantity";
            this.purchaseTextBoxQuantity.PasswordChar = '\0';
            this.purchaseTextBoxQuantity.SelectedText = "";
            this.purchaseTextBoxQuantity.Size = new System.Drawing.Size(215, 30);
            this.purchaseTextBoxQuantity.TabIndex = 28;
            // 
            // purchaseTextBoxprice
            // 
            this.purchaseTextBoxprice.BackColor = System.Drawing.Color.White;
            this.purchaseTextBoxprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchaseTextBoxprice.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.purchaseTextBoxprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.purchaseTextBoxprice.LineColor = System.Drawing.Color.Gainsboro;
            this.purchaseTextBoxprice.Location = new System.Drawing.Point(206, 183);
            this.purchaseTextBoxprice.Name = "purchaseTextBoxprice";
            this.purchaseTextBoxprice.PasswordChar = '\0';
            this.purchaseTextBoxprice.SelectedText = "";
            this.purchaseTextBoxprice.Size = new System.Drawing.Size(215, 30);
            this.purchaseTextBoxprice.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Product Information";
            // 
            // pruchasedataGridView
            // 
            this.pruchasedataGridView.AllowUserToAddRows = false;
            this.pruchasedataGridView.AllowUserToDeleteRows = false;
            this.pruchasedataGridView.AllowUserToResizeColumns = false;
            this.pruchasedataGridView.AllowUserToResizeRows = false;
            this.pruchasedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pruchasedataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pruchasedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pruchasedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pruchasedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pruchasedataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pruchasedataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pruchasedataGridView.Location = new System.Drawing.Point(0, 515);
            this.pruchasedataGridView.Name = "pruchasedataGridView";
            this.pruchasedataGridView.ReadOnly = true;
            this.pruchasedataGridView.RowHeadersWidth = 51;
            this.pruchasedataGridView.Size = new System.Drawing.Size(1200, 85);
            this.pruchasedataGridView.TabIndex = 39;
            // 
            // btnAddProductInvoice
            // 
            this.btnAddProductInvoice.AnimationHoverSpeed = 0.07F;
            this.btnAddProductInvoice.AnimationSpeed = 0.03F;
            this.btnAddProductInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProductInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnAddProductInvoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddProductInvoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddProductInvoice.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddProductInvoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddProductInvoice.CheckedImage")));
            this.btnAddProductInvoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddProductInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProductInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProductInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddProductInvoice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductInvoice.ForeColor = System.Drawing.Color.White;
            this.btnAddProductInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProductInvoice.Image")));
            this.btnAddProductInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProductInvoice.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddProductInvoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddProductInvoice.Location = new System.Drawing.Point(206, 370);
            this.btnAddProductInvoice.Name = "btnAddProductInvoice";
            this.btnAddProductInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddProductInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddProductInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddProductInvoice.OnHoverImage = null;
            this.btnAddProductInvoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddProductInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddProductInvoice.Size = new System.Drawing.Size(215, 42);
            this.btnAddProductInvoice.TabIndex = 41;
            this.btnAddProductInvoice.Text = "Add Product";
            this.btnAddProductInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProductInvoice.Click += new System.EventHandler(this.btnAddProductInvoice_Click);
            // 
            // btnAddInvoiceAll
            // 
            this.btnAddInvoiceAll.AnimationHoverSpeed = 0.07F;
            this.btnAddInvoiceAll.AnimationSpeed = 0.03F;
            this.btnAddInvoiceAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddInvoiceAll.BorderColor = System.Drawing.Color.Black;
            this.btnAddInvoiceAll.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddInvoiceAll.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddInvoiceAll.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddInvoiceAll.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddInvoiceAll.CheckedImage")));
            this.btnAddInvoiceAll.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddInvoiceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInvoiceAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddInvoiceAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddInvoiceAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoiceAll.ForeColor = System.Drawing.Color.White;
            this.btnAddInvoiceAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInvoiceAll.Image")));
            this.btnAddInvoiceAll.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAddInvoiceAll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInvoiceAll.Location = new System.Drawing.Point(585, 192);
            this.btnAddInvoiceAll.Name = "btnAddInvoiceAll";
            this.btnAddInvoiceAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddInvoiceAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddInvoiceAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddInvoiceAll.OnHoverImage = null;
            this.btnAddInvoiceAll.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddInvoiceAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddInvoiceAll.Size = new System.Drawing.Size(160, 160);
            this.btnAddInvoiceAll.TabIndex = 40;
            this.btnAddInvoiceAll.Text = "Add Invoice";
            this.btnAddInvoiceAll.Click += new System.EventHandler(this.btnAddInvoiceAll_Click);
            // 
            // PurchaseInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnAddProductInvoice);
            this.Controls.Add(this.btnAddInvoiceAll);
            this.Controls.Add(this.pruchasedataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsComBoxPurchase);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.purchaseTextBoxGuarantee);
            this.Controls.Add(this.purchaseTextBoxQuantity);
            this.Controls.Add(this.purchaseTextBoxprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplierLabl);
            this.Controls.Add(this.suplierComboBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PurchaseInvoiceForm";
            this.Text = "PurchaseInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.pruchasedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox suplierComboBox;
        private Guna.UI.WinForms.GunaLabel supplierLabl;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox productsComBoxPurchase;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel priceProduct;
        private Guna.UI.WinForms.GunaLabel nameProduct;
        private Guna.UI.WinForms.GunaLineTextBox purchaseTextBoxGuarantee;
        private Guna.UI.WinForms.GunaLineTextBox purchaseTextBoxQuantity;
        private Guna.UI.WinForms.GunaLineTextBox purchaseTextBoxprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pruchasedataGridView;
        private Guna.UI.WinForms.GunaAdvenceTileButton btnAddInvoiceAll;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddProductInvoice;
    }
}