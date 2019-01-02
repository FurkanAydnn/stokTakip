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
    public partial class BrandsManage : Form
    {
        public BrandsManage()
        {
            InitializeComponent();
        }
        Brand newBrand = new Brand();
        BrandRepo br = new BrandRepo();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            newBrand.BrandName = txtBrandName.Text;
            br.InsertBrand(newBrand);
            MessageBox.Show("Marka Kaydedildi.");
            txtBrandName.Clear();
            RefreshListBox();
        }
        private void BrandsManage_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lbBrands.SelectedItem != null)
            {
                DialogResult chose = MessageBox.Show("Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo);
                if (chose == DialogResult.Yes)
                    br.DeleteBrand((int)lbBrands.SelectedValue);
                RefreshListBox();
            }
            else
                MessageBox.Show("Lütfen Marka Seçin");
        }
        private void RefreshListBox()
        {
            List<Brand> brandList = br.GetBrands();
            lbBrands.DisplayMember = "BrandName";
            lbBrands.ValueMember = "ID";
            lbBrands.DataSource = brandList;
        }
    }
}
