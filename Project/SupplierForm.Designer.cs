namespace Project
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.PhoneSupplier = new Guna.UI.WinForms.GunaLabel();
            this.nameSupplier = new Guna.UI.WinForms.GunaLabel();
            this.SupplierTextBoxAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.SupplierTextBoxphone = new Guna.UI.WinForms.GunaLineTextBox();
            this.SupplierBoxname = new Guna.UI.WinForms.GunaLineTextBox();
            this.Supplier = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SupplierDataGridView2 = new System.Windows.Forms.DataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressLabel.Location = new System.Drawing.Point(143, 243);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(82, 28);
            this.AddressLabel.TabIndex = 34;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneSupplier
            // 
            this.PhoneSupplier.AutoSize = true;
            this.PhoneSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneSupplier.Location = new System.Drawing.Point(143, 197);
            this.PhoneSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneSupplier.Name = "PhoneSupplier";
            this.PhoneSupplier.Size = new System.Drawing.Size(67, 28);
            this.PhoneSupplier.TabIndex = 33;
            this.PhoneSupplier.Text = "Phone";
            // 
            // nameSupplier
            // 
            this.nameSupplier.AutoSize = true;
            this.nameSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSupplier.ForeColor = System.Drawing.SystemColors.Control;
            this.nameSupplier.Location = new System.Drawing.Point(143, 153);
            this.nameSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameSupplier.Name = "nameSupplier";
            this.nameSupplier.Size = new System.Drawing.Size(64, 28);
            this.nameSupplier.TabIndex = 32;
            this.nameSupplier.Text = "Name";
            // 
            // SupplierTextBoxAddress
            // 
            this.SupplierTextBoxAddress.BackColor = System.Drawing.Color.White;
            this.SupplierTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierTextBoxAddress.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierTextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierTextBoxAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierTextBoxAddress.Location = new System.Drawing.Point(271, 243);
            this.SupplierTextBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.SupplierTextBoxAddress.Name = "SupplierTextBoxAddress";
            this.SupplierTextBoxAddress.PasswordChar = '\0';
            this.SupplierTextBoxAddress.SelectedText = "";
            this.SupplierTextBoxAddress.Size = new System.Drawing.Size(161, 30);
            this.SupplierTextBoxAddress.TabIndex = 31;
            // 
            // SupplierTextBoxphone
            // 
            this.SupplierTextBoxphone.BackColor = System.Drawing.Color.White;
            this.SupplierTextBoxphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierTextBoxphone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierTextBoxphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierTextBoxphone.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierTextBoxphone.Location = new System.Drawing.Point(271, 197);
            this.SupplierTextBoxphone.Margin = new System.Windows.Forms.Padding(2);
            this.SupplierTextBoxphone.Name = "SupplierTextBoxphone";
            this.SupplierTextBoxphone.PasswordChar = '\0';
            this.SupplierTextBoxphone.SelectedText = "";
            this.SupplierTextBoxphone.Size = new System.Drawing.Size(161, 30);
            this.SupplierTextBoxphone.TabIndex = 30;
            // 
            // SupplierBoxname
            // 
            this.SupplierBoxname.BackColor = System.Drawing.Color.White;
            this.SupplierBoxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SupplierBoxname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SupplierBoxname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SupplierBoxname.LineColor = System.Drawing.Color.Gainsboro;
            this.SupplierBoxname.Location = new System.Drawing.Point(271, 153);
            this.SupplierBoxname.Margin = new System.Windows.Forms.Padding(2);
            this.SupplierBoxname.Name = "SupplierBoxname";
            this.SupplierBoxname.PasswordChar = '\0';
            this.SupplierBoxname.SelectedText = "";
            this.SupplierBoxname.Size = new System.Drawing.Size(161, 30);
            this.SupplierBoxname.TabIndex = 29;
            // 
            // Supplier
            // 
            this.Supplier.AnimationHoverSpeed = 0.07F;
            this.Supplier.AnimationSpeed = 0.03F;
            this.Supplier.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Supplier.BorderColor = System.Drawing.Color.Black;
            this.Supplier.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Supplier.CheckedBorderColor = System.Drawing.Color.Black;
            this.Supplier.CheckedForeColor = System.Drawing.Color.White;
            this.Supplier.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Supplier.CheckedImage")));
            this.Supplier.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Supplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Supplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Supplier.FocusedColor = System.Drawing.Color.Empty;
            this.Supplier.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.Supplier.ForeColor = System.Drawing.Color.White;
            this.Supplier.Image = ((System.Drawing.Image)(resources.GetObject("Supplier.Image")));
            this.Supplier.ImageSize = new System.Drawing.Size(52, 52);
            this.Supplier.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplier.Location = new System.Drawing.Point(540, 128);
            this.Supplier.Name = "Supplier";
            this.Supplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Supplier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Supplier.OnHoverForeColor = System.Drawing.Color.White;
            this.Supplier.OnHoverImage = null;
            this.Supplier.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Supplier.OnPressedColor = System.Drawing.Color.Black;
            this.Supplier.Size = new System.Drawing.Size(160, 160);
            this.Supplier.TabIndex = 35;
            this.Supplier.Text = "Add Supplier";
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // SupplierDataGridView2
            // 
            this.SupplierDataGridView2.AllowUserToAddRows = false;
            this.SupplierDataGridView2.AllowUserToDeleteRows = false;
            this.SupplierDataGridView2.AllowUserToResizeColumns = false;
            this.SupplierDataGridView2.AllowUserToResizeRows = false;
            this.SupplierDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SupplierDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.SupplierDataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SupplierDataGridView2.EnableHeadersVisualStyles = false;
            this.SupplierDataGridView2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SupplierDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SupplierDataGridView2.Location = new System.Drawing.Point(0, 478);
            this.SupplierDataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.SupplierDataGridView2.Name = "SupplierDataGridView2";
            this.SupplierDataGridView2.ReadOnly = true;
            this.SupplierDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SupplierDataGridView2.RowHeadersWidth = 51;
            this.SupplierDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SupplierDataGridView2.Size = new System.Drawing.Size(1200, 122);
            this.SupplierDataGridView2.TabIndex = 36;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(71, 72);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(165, 27);
            this.gunaLabel1.TabIndex = 37;
            this.gunaLabel1.Text = "Supplier Page";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.SupplierDataGridView2);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneSupplier);
            this.Controls.Add(this.nameSupplier);
            this.Controls.Add(this.SupplierTextBoxAddress);
            this.Controls.Add(this.SupplierTextBoxphone);
            this.Controls.Add(this.SupplierBoxname);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel AddressLabel;
        private Guna.UI.WinForms.GunaLabel PhoneSupplier;
        private Guna.UI.WinForms.GunaLabel nameSupplier;
        private Guna.UI.WinForms.GunaLineTextBox SupplierTextBoxAddress;
        private Guna.UI.WinForms.GunaLineTextBox SupplierTextBoxphone;
        private Guna.UI.WinForms.GunaLineTextBox SupplierBoxname;
        private Guna.UI.WinForms.GunaAdvenceTileButton Supplier;
        private System.Windows.Forms.DataGridView SupplierDataGridView2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}