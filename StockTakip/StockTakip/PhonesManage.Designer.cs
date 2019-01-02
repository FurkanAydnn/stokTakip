namespace StockTakip
{
    partial class PhonesManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonesManage));
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementDataSet = new StockTakip.StockManagementDataSet();
            this.txtModelCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNewPhone = new System.Windows.Forms.Button();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.brandsTableAdapter = new StockTakip.StockManagementDataSetTableAdapters.BrandsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhones
            // 
            resources.ApplyResources(this.dgvPhones, "dgvPhones");
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Name = "dgvPhones";
            // 
            // cbBrands
            // 
            resources.ApplyResources(this.cbBrands, "cbBrands");
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Name = "cbBrands";
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.stockManagementDataSet;
            // 
            // stockManagementDataSet
            // 
            this.stockManagementDataSet.DataSetName = "StockManagementDataSet";
            this.stockManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModelCode
            // 
            resources.ApplyResources(this.txtModelCode, "txtModelCode");
            this.txtModelCode.Name = "txtModelCode";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewPhone
            // 
            resources.ApplyResources(this.btnAddNewPhone, "btnAddNewPhone");
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.UseVisualStyleBackColor = true;
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // btnDeletePhone
            // 
            resources.ApplyResources(this.btnDeletePhone, "btnDeletePhone");
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // PhonesManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeletePhone);
            this.Controls.Add(this.btnAddNewPhone);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtModelCode);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.dgvPhones);
            this.Name = "PhonesManage";
            this.Load += new System.EventHandler(this.PhonesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.TextBox txtModelCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNewPhone;
        private System.Windows.Forms.Button btnDeletePhone;
        private StockManagementDataSet stockManagementDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private StockManagementDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
    }
}