using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTakip.ViewModels
{
    class PhoneCaseViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CaseColor Color { get; set; }
        public int StockQTY { get; set; }
    }
}
