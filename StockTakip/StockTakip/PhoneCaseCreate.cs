using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakip
{
    public partial class PhoneCaseCreate : Form
    {
        public PhoneCaseCreate()
        {
            InitializeComponent();
        }

        private void PhoneCaseCreate_Load(object sender, EventArgs e)
        {
            FillColors();
            FillPhoneCasesCombo();
            RefreshCurrentStock();
        }

        private void FillPhoneCasesCombo()
        {
            cbPhoneCase.DataSource = null;
            List<PhoneCase> CaseList = Program.PhoneCaseRepo.GetPhoneCases();
            cbPhoneCase.DisplayMember = "ProductName";
            cbPhoneCase.ValueMember = "ID";
            cbPhoneCase.DataSource = CaseList;
        }

        private void FillColors()
        {
            Type T = typeof(CaseColor);
            List<string> options;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                options = T.GetEnumNames().ToList();
            }
            else
            {
                var attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var attrNames = attrs.SelectMany(x => x.ConstructorArguments);
                options = attrNames.Select(x => (string)x.Value).ToList();

            }
            cbColor.DataSource = options;
        }

        internal void SelectPhoneCase(int selectedId)
        {
            tabControl1.SelectTab(1);
            cbPhoneCase.SelectedValue = selectedId;
        }

        private void btnCreateStock_Click(object sender, EventArgs e)
        {
            PhoneCase newPhoneCase = new PhoneCase();
            newPhoneCase.Price = nudPrice.Value;
            newPhoneCase.ProductName = txtName.Text;
            newPhoneCase.StockQTY = (int)nudQuantity.Value;
            newPhoneCase.CaseColor = (CaseColor)cbColor.SelectedIndex;
            Program.PhoneCaseRepo.InsertPhoneCase(newPhoneCase);
            MessageBox.Show("Eklendi..");
            RefreshMainGrid();
            FillPhoneCasesCombo();
            nudPrice.Value = 0;
            txtName.Clear();
            nudQuantity.Value = 0;
            cbColor.SelectedIndex = 0;


        }

        private void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"];
            if (f != null)
                f.FillGrid();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int id = (int)cbPhoneCase.SelectedValue;
            int qty = (int)nudAddQuantity.Value;
            Program.PhoneCaseRepo.AddStockToPhoneCase(id, qty);
            RefreshMainGrid();
            FillPhoneCasesCombo();
            cbPhoneCase.SelectedIndex = 0;
            nudAddQuantity.Value = 0;
        }

        private void nudAddQuantity_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }
        private void RefreshCurrentStock()
        {
            if (cbPhoneCase.SelectedItem == null)
                return;

            string template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en" ? "Stock will be updated as 0 when saved." : "Kaydettiğinizde adet 0 olarak güncellenecektir.";
            PhoneCase selectedCase = (PhoneCase)cbPhoneCase.SelectedItem;
            int currentStock = selectedCase.StockQTY;
            int latestStock = currentStock + (int)nudAddQuantity.Value;
            lblState.Text = template.Replace("0", latestStock.ToString());
        }

        private void cbPhoneCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }
    }
}
