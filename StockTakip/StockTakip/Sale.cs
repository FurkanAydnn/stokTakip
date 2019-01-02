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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            dgvPhones.DataSource = Program.PhoneRepo.GetPhonesForSale();
            dgvPhoneCases.DataSource = Program.PhoneCaseRepo.GetPhoneCasesForDisplay();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvPhones.SelectedRows)
            {
                Phone p1 = new Phone();
                p1.ProductName = item.Cells["Name"].Value.ToString();
                p1.ID = (int)item.Cells["ID"].Value;
                p1.Brand = new Brand();
                p1.Brand.BrandName = item.Cells["BrandName"].Value.ToString();
                lbCart.DisplayMember = "FullName";
                lbCart.Items.Add(p1);
                Program.SqlHelper.ExecuteProc("AddtoCart", p1.ID);
            }
            Sale_Load(sender, e);
        }

        private void btnAddCase_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvPhoneCases.SelectedRows)
            {
                PhoneCase p1 = new PhoneCase();
                p1.ProductName = item.Cells["Name"].Value.ToString();
                p1.ID = (int)item.Cells["ID"].Value;
                lbCart.DisplayMember = "ProductName";
                lbCart.Items.Add(p1);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedItem is Phone)
            {
                Phone selectedPhone = new Phone();
                selectedPhone = (Phone)lbCart.SelectedItem;
                Program.SqlHelper.ExecuteProc("RemoveFromCart",selectedPhone.ID);
                lbCart.Items.Remove(selectedPhone);
            }
            Sale_Load(sender,e);
        }
    }
}
