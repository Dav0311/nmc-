using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery.BLL
{
    class saledetailsBLL
    {
        public int ID { get; set; }
        public string customerNumber { get; set; }
        public string productName { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public decimal balance { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
    }
}
