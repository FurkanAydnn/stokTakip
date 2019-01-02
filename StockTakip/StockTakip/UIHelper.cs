using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakip
{
    static class UIHelper
    {
        public static void FillBrandCombobox(ComboBox cb, string firstOption)
        {
            cb.DisplayMember = "BrandName";
            cb.ValueMember = "ID";
            var liste = Program.BrandRepo.GetBrands();
            Brand b = new Brand() { ID = 0, BrandName = firstOption };
            liste.Insert(0, b);
            cb.DataSource = liste;
        }
    }
}
