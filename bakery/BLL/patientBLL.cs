using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bakery.BLL
{
    class patientBLL
    {
        public int ID { get; set; }
        public DateTime visitDate { get; set; }
        public string patient_firstName { get; set; }
        public string patient_lastName { get; set; }
        public string occupation { get; set; }
        public string residence { get; set; }
        public string consultant { get; set; }
        public string ms_history { get; set; }
        public string lab_tests { get; set; }
        public string diagnosis { get; set; }
        public string added_by { get; set; }

    }
}
