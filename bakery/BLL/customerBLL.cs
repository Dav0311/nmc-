﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery.BLL
{
    class customerBLL
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
    }
}
