using StockTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakip
{
    static class Program
    {
        public static BrandRepo BrandRepo = new BrandRepo();
        public static PhoneRepo PhoneRepo = new PhoneRepo();
        public static SqlHelper SqlHelper = new SqlHelper();
        public static PhoneCaseRepo PhoneCaseRepo = new PhoneCaseRepo();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
