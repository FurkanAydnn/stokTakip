using StockTakip.BusinessLogic;
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
    public partial class PhoneCaseManage : Form
    {
        public PhoneCaseManage()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            dgvPhoneCases.DataSource = null;
            dgvPhoneCases.DataSource = Program.PhoneCaseRepo.GetPhoneCasesForDisplay();
        }

        private void PhoneCaseManage_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvPhoneCases.SelectedRows.Count == 0)
                new PhoneCaseCreate().Show();
            else
            {
                int selectedId = (int)dgvPhoneCases.SelectedRows[0].Cells["ID"].Value;
                PhoneCaseCreate f = new PhoneCaseCreate();
                f.Show();
                f.SelectPhoneCase(selectedId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvPhoneCases.SelectedRows)
            {
                int CaseId = (int)item.Cells["ID"].Value;
                Program.PhoneCaseRepo.Delete(CaseId);
            }
            FillGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            dgvPhoneCases.ClearSelection();
            btnAdd.PerformClick();
        }
    }
}
