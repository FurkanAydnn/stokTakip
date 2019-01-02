using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace StockTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Language language = new Language();
        JavaScriptSerializer jss = new JavaScriptSerializer();
        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandsManage f = new BrandsManage();
            f.MdiParent = this;
            f.Show();
        }
        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonesManage f = new PhonesManage();
            f.MdiParent = this;
            f.Show();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("tr-TR");
            CultureInfo.CurrentUICulture = new CultureInfo("tr-TR");
            language.Lang = "tr-TR";
            var txtjson = jss.Serialize(language.Lang);
            File.WriteAllText("settings.json", txtjson);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            CultureInfo.CurrentUICulture = new CultureInfo("en-US");
            language.Lang = "en-US";
            var txtjson = jss.Serialize(language.Lang);
            File.WriteAllText("settings.json", txtjson);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                string content = File.ReadAllText("settings.json");
                string language = jss.Deserialize<string>(content);
                CultureInfo.CurrentCulture = new CultureInfo(language);
                CultureInfo.CurrentUICulture = new CultureInfo(language);
                this.Controls.Clear();
                InitializeComponent();
            }
        }

        private void phoneCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneCaseManage f = new PhoneCaseManage();
            f.MdiParent = this;
            f.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale f = new Sale();
            f.MdiParent = this;
            f.Show();
        }
    }
}
