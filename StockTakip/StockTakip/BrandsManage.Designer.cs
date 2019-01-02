namespace StockTakip
{
    partial class BrandsManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandsManage));
            this.lbBrands = new System.Windows.Forms.ListBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBrands
            // 
            resources.ApplyResources(this.lbBrands, "lbBrands");
            this.lbBrands.FormattingEnabled = true;
            this.lbBrands.Name = "lbBrands";
            // 
            // txtBrandName
            // 
            resources.ApplyResources(this.txtBrandName, "txtBrandName");
            this.txtBrandName.Name = "txtBrandName";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteSelected
            // 
            resources.ApplyResources(this.btnDeleteSelected, "btnDeleteSelected");
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BrandsManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.lbBrands);
            this.Name = "BrandsManage";
            this.Load += new System.EventHandler(this.BrandsManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBrands;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}