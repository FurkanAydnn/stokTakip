namespace StockTakip
{
    partial class PhoneCaseCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCaseCreate));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateStock = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbPhoneCase = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nudQuantity);
            this.tabPage1.Controls.Add(this.cbColor);
            this.tabPage1.Controls.Add(this.nudPrice);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreateStock);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // nudQuantity
            // 
            resources.ApplyResources(this.nudQuantity, "nudQuantity");
            this.nudQuantity.Name = "nudQuantity";
            // 
            // cbColor
            // 
            resources.ApplyResources(this.cbColor, "cbColor");
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Name = "cbColor";
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
            // btnCreateStock
            // 
            resources.ApplyResources(this.btnCreateStock, "btnCreateStock");
            this.btnCreateStock.Name = "btnCreateStock";
            this.btnCreateStock.UseVisualStyleBackColor = true;
            this.btnCreateStock.Click += new System.EventHandler(this.btnCreateStock_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.btnAddStock);
            this.tabPage2.Controls.Add(this.lblState);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nudAddQuantity);
            this.tabPage2.Controls.Add(this.cbPhoneCase);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddStock
            // 
            resources.ApplyResources(this.btnAddStock, "btnAddStock");
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // lblState
            // 
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.Name = "lblState";
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
            // nudAddQuantity
            // 
            resources.ApplyResources(this.nudAddQuantity, "nudAddQuantity");
            this.nudAddQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAddQuantity.Name = "nudAddQuantity";
            this.nudAddQuantity.TabStop = false;
            this.nudAddQuantity.ValueChanged += new System.EventHandler(this.nudAddQuantity_ValueChanged);
            this.nudAddQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudAddQuantity_ValueChanged);
            // 
            // cbPhoneCase
            // 
            resources.ApplyResources(this.cbPhoneCase, "cbPhoneCase");
            this.cbPhoneCase.FormattingEnabled = true;
            this.cbPhoneCase.Name = "cbPhoneCase";
            this.cbPhoneCase.SelectedIndexChanged += new System.EventHandler(this.cbPhoneCase_SelectedIndexChanged);
            // 
            // PhoneCaseCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "PhoneCaseCreate";
            this.Load += new System.EventHandler(this.PhoneCaseCreate_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateStock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAddQuantity;
        private System.Windows.Forms.ComboBox cbPhoneCase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}