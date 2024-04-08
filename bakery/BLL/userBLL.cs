using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery.BLL
{
    class userBLL
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string usertype { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
        public string role { get; set; }

    }
}
