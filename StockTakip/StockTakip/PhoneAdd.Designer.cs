namespace StockTakip
{
    partial class PhoneAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneAdd));
            this.stockManagementDataSet = new StockTakip.StockManagementDataSet();
            this.stockManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter = new StockTakip.StockManagementDataSetTableAdapters.BrandsTableAdapter();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtModelCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.txtIMEI2 = new System.Windows.Forms.TextBox();
            this.txtIMEI1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // stockManagementDataSet
            // 
            this.stockManagementDataSet.DataSetName = "StockManagementDataSet";
            this.stockManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockManagementDataSetBindingSource
            // 
            this.stockManagementDataSetBindingSource.DataSource = this.stockManagementDataSet;
            this.stockManagementDataSetBindingSource.Position = 0;
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.stockManagementDataSetBindingSource;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // nudPrice
            // 
            resources.ApplyResources(this.nudPrice, "nudPrice");
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtModelCode
            // 
            resources.ApplyResources(this.txtModelCode, "txtModelCode");
            this.txtModelCode.Name = "txtModelCode";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbBrands
            // 
            resources.ApplyResources(this.cbBrands, "cbBrands");
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Name = "cbBrands";
            // 
            // txtIMEI2
            // 
            resources.ApplyResources(this.txtIMEI2, "txtIMEI2");
            this.txtIMEI2.Name = "txtIMEI2";
            // 
            // txtIMEI1
            // 
            resources.ApplyResources(this.txtIMEI1, "txtIMEI1");
            this.txtIMEI1.Name = "txtIMEI1";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PhoneAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModelCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.txtIMEI2);
            this.Controls.Add(this.txtIMEI1);
            this.Controls.Add(this.btnAdd);
            this.Name = "PhoneAdd";
            this.Load += new System.EventHandler(this.PhoneAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource stockManagementDataSetBindingSource;
        private StockManagementDataSet stockManagementDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private StockManagementDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtModelCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.TextBox txtIMEI2;
        private System.Windows.Forms.TextBox txtIMEI1;
        private System.Windows.Forms.Button btnAdd;
    }
}