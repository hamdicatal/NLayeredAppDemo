namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.gpbAddNew = new System.Windows.Forms.GroupBox();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.lblNewUnitPrice = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.lblNewStockAmount = new System.Windows.Forms.Label();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.txtNewUnitPrice = new System.Windows.Forms.TextBox();
            this.txtNewStockAmount = new System.Windows.Forms.TextBox();
            this.cmbNewCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 97);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(730, 173);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(44, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(102, 19);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(233, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(18, 49);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(102, 46);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(233, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.lblCategory);
            this.gpbSearch.Controls.Add(this.txtProductName);
            this.gpbSearch.Controls.Add(this.lblProductName);
            this.gpbSearch.Controls.Add(this.cmbCategory);
            this.gpbSearch.Location = new System.Drawing.Point(12, 12);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(356, 79);
            this.gpbSearch.TabIndex = 4;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Search";
            // 
            // gpbAddNew
            // 
            this.gpbAddNew.Controls.Add(this.btnAdd);
            this.gpbAddNew.Controls.Add(this.cmbNewCategory);
            this.gpbAddNew.Controls.Add(this.txtNewQuantityPerUnit);
            this.gpbAddNew.Controls.Add(this.txtNewStockAmount);
            this.gpbAddNew.Controls.Add(this.txtNewUnitPrice);
            this.gpbAddNew.Controls.Add(this.txtNewProductName);
            this.gpbAddNew.Controls.Add(this.label1);
            this.gpbAddNew.Controls.Add(this.lblNewStockAmount);
            this.gpbAddNew.Controls.Add(this.lblNewCategory);
            this.gpbAddNew.Controls.Add(this.lblNewUnitPrice);
            this.gpbAddNew.Controls.Add(this.lblNewProductName);
            this.gpbAddNew.Location = new System.Drawing.Point(12, 276);
            this.gpbAddNew.Name = "gpbAddNew";
            this.gpbAddNew.Size = new System.Drawing.Size(356, 196);
            this.gpbAddNew.TabIndex = 5;
            this.gpbAddNew.TabStop = false;
            this.gpbAddNew.Text = "Add Record";
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(18, 27);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(78, 13);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "Product Name:";
            // 
            // lblNewUnitPrice
            // 
            this.lblNewUnitPrice.AutoSize = true;
            this.lblNewUnitPrice.Location = new System.Drawing.Point(40, 80);
            this.lblNewUnitPrice.Name = "lblNewUnitPrice";
            this.lblNewUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblNewUnitPrice.TabIndex = 0;
            this.lblNewUnitPrice.Text = "Unit Price:";
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new System.Drawing.Point(44, 53);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(52, 13);
            this.lblNewCategory.TabIndex = 0;
            this.lblNewCategory.Text = "Category:";
            // 
            // lblNewStockAmount
            // 
            this.lblNewStockAmount.AutoSize = true;
            this.lblNewStockAmount.Location = new System.Drawing.Point(19, 106);
            this.lblNewStockAmount.Name = "lblNewStockAmount";
            this.lblNewStockAmount.Size = new System.Drawing.Size(77, 13);
            this.lblNewStockAmount.TabIndex = 0;
            this.lblNewStockAmount.Text = "Stock Amount:";
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(102, 24);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(233, 20);
            this.txtNewProductName.TabIndex = 1;
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.Location = new System.Drawing.Point(102, 77);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(233, 20);
            this.txtNewUnitPrice.TabIndex = 1;
            // 
            // txtNewStockAmount
            // 
            this.txtNewStockAmount.Location = new System.Drawing.Point(102, 103);
            this.txtNewStockAmount.Name = "txtNewStockAmount";
            this.txtNewStockAmount.Size = new System.Drawing.Size(233, 20);
            this.txtNewStockAmount.TabIndex = 1;
            // 
            // cmbNewCategory
            // 
            this.cmbNewCategory.FormattingEnabled = true;
            this.cmbNewCategory.Location = new System.Drawing.Point(102, 50);
            this.cmbNewCategory.Name = "cmbNewCategory";
            this.cmbNewCategory.Size = new System.Drawing.Size(233, 21);
            this.cmbNewCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity Per Unit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewQuantityPerUnit
            // 
            this.txtNewQuantityPerUnit.Location = new System.Drawing.Point(102, 129);
            this.txtNewQuantityPerUnit.Name = "txtNewQuantityPerUnit";
            this.txtNewQuantityPerUnit.Size = new System.Drawing.Size(233, 20);
            this.txtNewQuantityPerUnit.TabIndex = 1;
            this.txtNewQuantityPerUnit.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 479);
            this.Controls.Add(this.gpbAddNew);
            this.Controls.Add(this.gpbSearch);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbAddNew.ResumeLayout(false);
            this.gpbAddNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbAddNew;
        private System.Windows.Forms.ComboBox cmbNewCategory;
        private System.Windows.Forms.TextBox txtNewQuantityPerUnit;
        private System.Windows.Forms.TextBox txtNewStockAmount;
        private System.Windows.Forms.TextBox txtNewUnitPrice;
        private System.Windows.Forms.TextBox txtNewProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewStockAmount;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Label lblNewUnitPrice;
        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.Button btnAdd;
    }
}

