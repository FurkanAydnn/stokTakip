using StockTakip.BusinessLogic;
using StockTakip.ViewModels;
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
    public partial class PhonesManage : Form
    {
        public PhonesManage()
        {
            InitializeComponent();
        }
        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            new PhoneAdd().Show();
        }

        private void PhonesManage_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandCombobox(cbBrands, Properties.Resources.AllBrands);
            FillPhonesGrid();
        }

        public void FillPhonesGrid()
        {
            dgvPhones.DataSource = null;
            dgvPhones.DataSource = Program.PhoneRepo.GetPhonesForDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPhones.DataSource = null;

            var chosenBrandId = (int)cbBrands.SelectedValue;
            dgvPhones.DataSource = Program.PhoneRepo.SearchPhone(chosenBrandId, txtModelCode.Text);

        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {

        }
    }
}
