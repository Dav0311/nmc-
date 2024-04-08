using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bakery.BLL
{
    class expenseBLL
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal cost { get; set; }
        public decimal qty { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }

    }
}
