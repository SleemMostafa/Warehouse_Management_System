namespace Project
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labllNameCategory = new Guna.UI.WinForms.GunaLabel();
            this.nameTextBoxCategory = new Guna.UI.WinForms.GunaTextBox();
            this.categoryBtnAdd = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.productOfCategoryGridView = new System.Windows.Forms.DataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfCategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labllNameCategory
            // 
            this.labllNameCategory.AutoSize = true;
            this.labllNameCategory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labllNameCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.labllNameCategory.Location = new System.Drawing.Point(105, 126);
            this.labllNameCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labllNameCategory.Name = "labllNameCategory";
            this.labllNameCategory.Size = new System.Drawing.Size(44, 20);
            this.labllNameCategory.TabIndex = 1;
            this.labllNameCategory.Text = "Name";
            // 
            // nameTextBoxCategory
            // 
            this.nameTextBoxCategory.BaseColor = System.Drawing.Color.White;
            this.nameTextBoxCategory.BorderColor = System.Drawing.Color.Silver;
            this.nameTextBoxCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBoxCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.nameTextBoxCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nameTextBoxCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTextBoxCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBoxCategory.Location = new System.Drawing.Point(204, 126);
            this.nameTextBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBoxCategory.Name = "nameTextBoxCategory";
            this.nameTextBoxCategory.PasswordChar = '\0';
            this.nameTextBoxCategory.SelectedText = "";
            this.nameTextBoxCategory.Size = new System.Drawing.Size(248, 32);
            this.nameTextBoxCategory.TabIndex = 2;
            //this.nameTextBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // categoryBtnAdd
            // 
            this.categoryBtnAdd.AnimationHoverSpeed = 0.07F;
            this.categoryBtnAdd.AnimationSpeed = 0.03F;
            this.categoryBtnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.categoryBtnAdd.BorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.categoryBtnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("categoryBtnAdd.CheckedImage")));
            this.categoryBtnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.categoryBtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.categoryBtnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.categoryBtnAdd.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.categoryBtnAdd.ForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtnAdd.Image")));
            this.categoryBtnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.categoryBtnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categoryBtnAdd.Location = new System.Drawing.Point(503, 108);
            this.categoryBtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.categoryBtnAdd.Name = "categoryBtnAdd";
            this.categoryBtnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.categoryBtnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.categoryBtnAdd.OnHoverImage = null;
            this.categoryBtnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.categoryBtnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.categoryBtnAdd.Size = new System.Drawing.Size(144, 120);
            this.categoryBtnAdd.TabIndex = 3;
            this.categoryBtnAdd.Text = "Add Category";
            this.categoryBtnAdd.Click += new System.EventHandler(this.categoryBtnAdd_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToAddRows = false;
            this.categoryGridView.AllowUserToDeleteRows = false;
            this.categoryGridView.AllowUserToResizeColumns = false;
            this.categoryGridView.AllowUserToResizeRows = false;
            this.categoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.categoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoryGridView.Location = new System.Drawing.Point(6, 317);
            this.categoryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersWidth = 51;
            this.categoryGridView.Size = new System.Drawing.Size(217, 133);
            this.categoryGridView.TabIndex = 4;
            this.categoryGridView.SelectionChanged += new System.EventHandler(this.categoryGridView_SelectionChanged);
            // 
            // productOfCategoryGridView
            // 
            this.productOfCategoryGridView.AllowUserToAddRows = false;
            this.productOfCategoryGridView.AllowUserToDeleteRows = false;
            this.productOfCategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productOfCategoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.productOfCategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productOfCategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOfCategoryGridView.Location = new System.Drawing.Point(217, 317);
            this.productOfCategoryGridView.Name = "productOfCategoryGridView";
            this.productOfCategoryGridView.ReadOnly = true;
            this.productOfCategoryGridView.RowHeadersWidth = 51;
            this.productOfCategoryGridView.Size = new System.Drawing.Size(584, 133);
            this.productOfCategoryGridView.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(51, 58);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(137, 22);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Category Page";
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.Image")));
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(700, 108);
            this.gunaAdvenceTileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = null;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(144, 120);
            this.gunaAdvenceTileButton1.TabIndex = 7;
            this.gunaAdvenceTileButton1.Text = "Edit Category";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.productOfCategoryGridView);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.categoryBtnAdd);
            this.Controls.Add(this.nameTextBoxCategory);
            this.Controls.Add(this.labllNameCategory);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOfCategoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel labllNameCategory;
        private Guna.UI.WinForms.GunaTextBox nameTextBoxCategory;
        private Guna.UI.WinForms.GunaAdvenceTileButton categoryBtnAdd;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.DataGridView productOfCategoryGridView;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
    }
}