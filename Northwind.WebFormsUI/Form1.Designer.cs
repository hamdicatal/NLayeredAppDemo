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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbNewCategory = new System.Windows.Forms.ComboBox();
            this.txtNewQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtNewStockAmount = new System.Windows.Forms.TextBox();
            this.txtNewUnitPrice = new System.Windows.Forms.TextBox();
            this.txtNewProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewStockAmount = new System.Windows.Forms.Label();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.lblNewUnitPrice = new System.Windows.Forms.Label();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.gpbUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.txtUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.txtUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUpdateProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbLog = new System.Windows.Forms.GroupBox();
            this.lblLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.gpbAddNew.SuspendLayout();
            this.gpbUpdate.SuspendLayout();
            this.gpbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 97);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(730, 173);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
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
            // cmbNewCategory
            // 
            this.cmbNewCategory.FormattingEnabled = true;
            this.cmbNewCategory.Location = new System.Drawing.Point(102, 50);
            this.cmbNewCategory.Name = "cmbNewCategory";
            this.cmbNewCategory.Size = new System.Drawing.Size(233, 21);
            this.cmbNewCategory.TabIndex = 2;
            // 
            // txtNewQuantityPerUnit
            // 
            this.txtNewQuantityPerUnit.Location = new System.Drawing.Point(102, 129);
            this.txtNewQuantityPerUnit.Name = "txtNewQuantityPerUnit";
            this.txtNewQuantityPerUnit.Size = new System.Drawing.Size(233, 20);
            this.txtNewQuantityPerUnit.TabIndex = 1;
            this.txtNewQuantityPerUnit.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNewStockAmount
            // 
            this.txtNewStockAmount.Location = new System.Drawing.Point(102, 103);
            this.txtNewStockAmount.Name = "txtNewStockAmount";
            this.txtNewStockAmount.Size = new System.Drawing.Size(233, 20);
            this.txtNewStockAmount.TabIndex = 1;
            // 
            // txtNewUnitPrice
            // 
            this.txtNewUnitPrice.Location = new System.Drawing.Point(102, 77);
            this.txtNewUnitPrice.Name = "txtNewUnitPrice";
            this.txtNewUnitPrice.Size = new System.Drawing.Size(233, 20);
            this.txtNewUnitPrice.TabIndex = 1;
            // 
            // txtNewProductName
            // 
            this.txtNewProductName.Location = new System.Drawing.Point(102, 24);
            this.txtNewProductName.Name = "txtNewProductName";
            this.txtNewProductName.Size = new System.Drawing.Size(233, 20);
            this.txtNewProductName.TabIndex = 1;
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
            // lblNewStockAmount
            // 
            this.lblNewStockAmount.AutoSize = true;
            this.lblNewStockAmount.Location = new System.Drawing.Point(19, 106);
            this.lblNewStockAmount.Name = "lblNewStockAmount";
            this.lblNewStockAmount.Size = new System.Drawing.Size(77, 13);
            this.lblNewStockAmount.TabIndex = 0;
            this.lblNewStockAmount.Text = "Stock Amount:";
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
            // lblNewUnitPrice
            // 
            this.lblNewUnitPrice.AutoSize = true;
            this.lblNewUnitPrice.Location = new System.Drawing.Point(40, 80);
            this.lblNewUnitPrice.Name = "lblNewUnitPrice";
            this.lblNewUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblNewUnitPrice.TabIndex = 0;
            this.lblNewUnitPrice.Text = "Unit Price:";
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
            // gpbUpdate
            // 
            this.gpbUpdate.Controls.Add(this.btnDelete);
            this.gpbUpdate.Controls.Add(this.btnUpdate);
            this.gpbUpdate.Controls.Add(this.cmbUpdateCategory);
            this.gpbUpdate.Controls.Add(this.txtUpdateQuantityPerUnit);
            this.gpbUpdate.Controls.Add(this.txtUpdateStockAmount);
            this.gpbUpdate.Controls.Add(this.txtUpdateUnitPrice);
            this.gpbUpdate.Controls.Add(this.txtUpdateProductName);
            this.gpbUpdate.Controls.Add(this.label2);
            this.gpbUpdate.Controls.Add(this.label3);
            this.gpbUpdate.Controls.Add(this.label4);
            this.gpbUpdate.Controls.Add(this.label5);
            this.gpbUpdate.Controls.Add(this.label6);
            this.gpbUpdate.Location = new System.Drawing.Point(386, 276);
            this.gpbUpdate.Name = "gpbUpdate";
            this.gpbUpdate.Size = new System.Drawing.Size(356, 196);
            this.gpbUpdate.TabIndex = 5;
            this.gpbUpdate.TabStop = false;
            this.gpbUpdate.Text = "Update Record";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(181, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 29);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // cmbUpdateCategory
            // 
            this.cmbUpdateCategory.FormattingEnabled = true;
            this.cmbUpdateCategory.Location = new System.Drawing.Point(102, 50);
            this.cmbUpdateCategory.Name = "cmbUpdateCategory";
            this.cmbUpdateCategory.Size = new System.Drawing.Size(233, 21);
            this.cmbUpdateCategory.TabIndex = 2;
            // 
            // txtUpdateQuantityPerUnit
            // 
            this.txtUpdateQuantityPerUnit.Location = new System.Drawing.Point(102, 129);
            this.txtUpdateQuantityPerUnit.Name = "txtUpdateQuantityPerUnit";
            this.txtUpdateQuantityPerUnit.Size = new System.Drawing.Size(233, 20);
            this.txtUpdateQuantityPerUnit.TabIndex = 1;
            this.txtUpdateQuantityPerUnit.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUpdateStockAmount
            // 
            this.txtUpdateStockAmount.Location = new System.Drawing.Point(102, 103);
            this.txtUpdateStockAmount.Name = "txtUpdateStockAmount";
            this.txtUpdateStockAmount.Size = new System.Drawing.Size(233, 20);
            this.txtUpdateStockAmount.TabIndex = 1;
            // 
            // txtUpdateUnitPrice
            // 
            this.txtUpdateUnitPrice.Location = new System.Drawing.Point(102, 77);
            this.txtUpdateUnitPrice.Name = "txtUpdateUnitPrice";
            this.txtUpdateUnitPrice.Size = new System.Drawing.Size(233, 20);
            this.txtUpdateUnitPrice.TabIndex = 1;
            // 
            // txtUpdateProductName
            // 
            this.txtUpdateProductName.Location = new System.Drawing.Point(102, 24);
            this.txtUpdateProductName.Name = "txtUpdateProductName";
            this.txtUpdateProductName.Size = new System.Drawing.Size(233, 20);
            this.txtUpdateProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity Per Unit:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product Name:";
            // 
            // gpbLog
            // 
            this.gpbLog.Controls.Add(this.lblLog);
            this.gpbLog.Location = new System.Drawing.Point(386, 12);
            this.gpbLog.Name = "gpbLog";
            this.gpbLog.Size = new System.Drawing.Size(356, 79);
            this.gpbLog.TabIndex = 6;
            this.gpbLog.TabStop = false;
            this.gpbLog.Text = "Log";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(28, 36);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 13);
            this.lblLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 479);
            this.Controls.Add(this.gpbLog);
            this.Controls.Add(this.gpbUpdate);
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
            this.gpbUpdate.ResumeLayout(false);
            this.gpbUpdate.PerformLayout();
            this.gpbLog.ResumeLayout(false);
            this.gpbLog.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateCategory;
        private System.Windows.Forms.TextBox txtUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUpdateStockAmount;
        private System.Windows.Forms.TextBox txtUpdateUnitPrice;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbLog;
        private System.Windows.Forms.Label lblLog;
    }
}

