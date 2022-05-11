namespace Project
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddressLabel = new Guna.UI.WinForms.GunaLabel();
            this.PhoneCustomer = new Guna.UI.WinForms.GunaLabel();
            this.nameCustomer = new Guna.UI.WinForms.GunaLabel();
            this.CustomerTextBoxAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerTextBoxphone = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerBoxname = new Guna.UI.WinForms.GunaLineTextBox();
            this.CustomerBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.CustomerDataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AddressLabel.Location = new System.Drawing.Point(151, 250);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(82, 28);
            this.AddressLabel.TabIndex = 43;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneCustomer
            // 
            this.PhoneCustomer.AutoSize = true;
            this.PhoneCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.PhoneCustomer.Location = new System.Drawing.Point(151, 204);
            this.PhoneCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneCustomer.Name = "PhoneCustomer";
            this.PhoneCustomer.Size = new System.Drawing.Size(67, 28);
            this.PhoneCustomer.TabIndex = 42;
            this.PhoneCustomer.Text = "Phone";
            // 
            // nameCustomer
            // 
            this.nameCustomer.AutoSize = true;
            this.nameCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.nameCustomer.Location = new System.Drawing.Point(151, 159);
            this.nameCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.Size = new System.Drawing.Size(64, 28);
            this.nameCustomer.TabIndex = 41;
            this.nameCustomer.Text = "Name";
            // 
            // CustomerTextBoxAddress
            // 
            this.CustomerTextBoxAddress.BackColor = System.Drawing.Color.White;
            this.CustomerTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTextBoxAddress.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerTextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerTextBoxAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerTextBoxAddress.Location = new System.Drawing.Point(281, 250);
            this.CustomerTextBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerTextBoxAddress.Name = "CustomerTextBoxAddress";
            this.CustomerTextBoxAddress.PasswordChar = '\0';
            this.CustomerTextBoxAddress.SelectedText = "";
            this.CustomerTextBoxAddress.Size = new System.Drawing.Size(161, 30);
            this.CustomerTextBoxAddress.TabIndex = 40;
            // 
            // CustomerTextBoxphone
            // 
            this.CustomerTextBoxphone.BackColor = System.Drawing.Color.White;
            this.CustomerTextBoxphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerTextBoxphone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerTextBoxphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerTextBoxphone.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerTextBoxphone.Location = new System.Drawing.Point(281, 204);
            this.CustomerTextBoxphone.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerTextBoxphone.Name = "CustomerTextBoxphone";
            this.CustomerTextBoxphone.PasswordChar = '\0';
            this.CustomerTextBoxphone.SelectedText = "";
            this.CustomerTextBoxphone.Size = new System.Drawing.Size(161, 30);
            this.CustomerTextBoxphone.TabIndex = 39;
            // 
            // CustomerBoxname
            // 
            this.CustomerBoxname.BackColor = System.Drawing.Color.White;
            this.CustomerBoxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerBoxname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerBoxname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerBoxname.LineColor = System.Drawing.Color.Gainsboro;
            this.CustomerBoxname.Location = new System.Drawing.Point(281, 159);
            this.CustomerBoxname.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerBoxname.Name = "CustomerBoxname";
            this.CustomerBoxname.PasswordChar = '\0';
            this.CustomerBoxname.SelectedText = "";
            this.CustomerBoxname.Size = new System.Drawing.Size(161, 30);
            this.CustomerBoxname.TabIndex = 38;
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.AnimationHoverSpeed = 0.07F;
            this.CustomerBtn.AnimationSpeed = 0.03F;
            this.CustomerBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CustomerBtn.BorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CustomerBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.CheckedForeColor = System.Drawing.Color.White;
            this.CustomerBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.CheckedImage")));
            this.CustomerBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CustomerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CustomerBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CustomerBtn.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.CustomerBtn.ForeColor = System.Drawing.Color.White;
            this.CustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.Image")));
            this.CustomerBtn.ImageSize = new System.Drawing.Size(52, 52);
            this.CustomerBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerBtn.Location = new System.Drawing.Point(544, 142);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CustomerBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CustomerBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CustomerBtn.OnHoverImage = null;
            this.CustomerBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CustomerBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CustomerBtn.Size = new System.Drawing.Size(160, 160);
            this.CustomerBtn.TabIndex = 44;
            this.CustomerBtn.Text = "Add Customer";
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // CustomerDataGridView2
            // 
            this.CustomerDataGridView2.AllowUserToAddRows = false;
            this.CustomerDataGridView2.AllowUserToDeleteRows = false;
            this.CustomerDataGridView2.AllowUserToResizeColumns = false;
            this.CustomerDataGridView2.AllowUserToResizeRows = false;
            this.CustomerDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomerDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CustomerDataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerDataGridView2.EnableHeadersVisualStyles = false;
            this.CustomerDataGridView2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.Location = new System.Drawing.Point(0, 328);
            this.CustomerDataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerDataGridView2.Name = "CustomerDataGridView2";
            this.CustomerDataGridView2.ReadOnly = true;
            this.CustomerDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.CustomerDataGridView2.RowHeadersWidth = 51;
            this.CustomerDataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CustomerDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerDataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView2.Size = new System.Drawing.Size(800, 122);
            this.CustomerDataGridView2.TabIndex = 45;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerDataGridView2);
            this.Controls.Add(this.CustomerBtn);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneCustomer);
            this.Controls.Add(this.nameCustomer);
            this.Controls.Add(this.CustomerTextBoxAddress);
            this.Controls.Add(this.CustomerTextBoxphone);
            this.Controls.Add(this.CustomerBoxname);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel AddressLabel;
        private Guna.UI.WinForms.GunaLabel PhoneCustomer;
        private Guna.UI.WinForms.GunaLabel nameCustomer;
        private Guna.UI.WinForms.GunaLineTextBox CustomerTextBoxAddress;
        private Guna.UI.WinForms.GunaLineTextBox CustomerTextBoxphone;
        private Guna.UI.WinForms.GunaLineTextBox CustomerBoxname;
        private Guna.UI.WinForms.GunaAdvenceTileButton CustomerBtn;
        private System.Windows.Forms.DataGridView CustomerDataGridView2;
    }
}