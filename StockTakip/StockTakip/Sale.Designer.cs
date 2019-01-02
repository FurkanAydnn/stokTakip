namespace StockTakip
{
    partial class Sale
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
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.dgvPhoneCases = new System.Windows.Forms.DataGridView();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneCases)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(495, 349);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 23);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Satış Yap";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(590, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvPhones
            // 
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Location = new System.Drawing.Point(13, 51);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhones.Size = new System.Drawing.Size(403, 125);
            this.dgvPhones.TabIndex = 5;
            // 
            // dgvPhoneCases
            // 
            this.dgvPhoneCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneCases.Location = new System.Drawing.Point(12, 218);
            this.dgvPhoneCases.Name = "dgvPhoneCases";
            this.dgvPhoneCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhoneCases.Size = new System.Drawing.Size(403, 125);
            this.dgvPhoneCases.TabIndex = 6;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(279, 182);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(136, 23);
            this.btnAddPhone.TabIndex = 7;
            this.btnAddPhone.Text = "Telefonu Sepete Ekle";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.Location = new System.Drawing.Point(279, 349);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(136, 23);
            this.btnAddCase.TabIndex = 8;
            this.btnAddCase.Text = "Kılıfı Sepete Ekle";
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.lbCart);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Location = new System.Drawing.Point(459, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepet";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 246);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Toplam: 0 TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefonlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon Kılıfları";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbCart
            // 
            this.lbCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCart.FormattingEnabled = true;
            this.lbCart.Location = new System.Drawing.Point(3, 16);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(202, 212);
            this.lbCart.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(127, 233);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 377);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.dgvPhoneCases);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSale);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneCases)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.DataGridView dgvPhoneCases;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbCart;
    }
}