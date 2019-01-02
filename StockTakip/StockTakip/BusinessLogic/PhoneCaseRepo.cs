using StockTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTakip.BusinessLogic
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> list = new List<PhoneCase>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM PHONECASE");
            foreach (DataRow item in dt.Rows)
            {
                PhoneCase pc = new PhoneCase();
                pc.ID = (int)item["ID"];
                pc.ProductName = item["ProductName"].ToString();
                pc.Price = (decimal)item["Price"];
                pc.CaseColor = (CaseColor)item["CaseColor"];
                pc.StockQTY = (int)item["Qty"];

                list.Add(pc);
            }
            return list;
        }
        public List<PhoneCaseViewModel> GetPhoneCasesForDisplay()
        {
            List<PhoneCaseViewModel> list = new List<PhoneCaseViewModel>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM PHONECASE");
            foreach (DataRow item in dt.Rows)
            {
                PhoneCaseViewModel pc = new PhoneCaseViewModel();
                pc.ID = (int)item["ID"];
                pc.Name = item["ProductName"].ToString();
                pc.Price = (decimal)item["Price"];
                pc.Color = (CaseColor)item["CaseColor"];
                pc.StockQTY = (int)item["Qty"];

                list.Add(pc);
            }
            return list;
        }
        public void InsertPhoneCase(PhoneCase newPhoneCase)
        {
            SqlParameter p1 = new SqlParameter("ProductName", newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("Price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("CaseColor", (int)newPhoneCase.CaseColor);
            SqlParameter p4 = new SqlParameter("StockQTY", newPhoneCase.StockQTY);
            Program.SqlHelper.ExecuteProc("InsertPhoneCase", p1, p2, p3, p4);
        }
        public void AddStockToPhoneCase(int id, int qty)
        {
            SqlParameter p1 = new SqlParameter("id", id);
            SqlParameter p2 = new SqlParameter("qty", qty);
            Program.SqlHelper.ExecuteProc("AddStock", p1, p2);
        }
        public void Delete(int CaseId)
        {
            Program.SqlHelper.ExecuteCommand("DELETE FROM PhoneCase WHERE ID=" + CaseId);
        }
    }
}
