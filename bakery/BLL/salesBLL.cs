using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery.BLL
{
    class salesBLL
    {
        public int ID { get; set; }
        public int customerNumber { get; set; }
        public decimal grandTotal { get; set; }
        public DateTime transactionDate { get; set; }
        
        public string added_by { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public decimal balance { get; set; }

      //   public decimal total { get; set; }


    }
}
