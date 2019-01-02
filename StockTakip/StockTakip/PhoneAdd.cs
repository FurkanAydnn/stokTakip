using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakip
{
    public partial class PhoneAdd : Form
    {
        public PhoneAdd()
        {
            InitializeComponent();
        }

        private void PhoneAdd_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandCombobox(cbBrands, Properties.Resources.Choose);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone();

            newPhone.IMEI1 = txtIMEI1.Text;
            newPhone.IMEI2 = txtIMEI2.Text;
            newPhone.ModelCode = txtModelCode.Text;
            newPhone.ProductName = txtName.Text;
            newPhone.Price = nudPrice.Value;
            newPhone.Brand = (Brand)cbBrands.SelectedItem;
            Program.PhoneRepo.InsertPhone(newPhone);
            MessageBox.Show("Telefon Kaydedildi.");

            RefreshMainPhoneGrid();
        }

        private void RefreshMainPhoneGrid()
        {
            Form openForm = Application.OpenForms["PhonesManage"];
            PhonesManage pcForm = (PhonesManage)openForm;
            pcForm.FillPhonesGrid();
        }
    }
}
