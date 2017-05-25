using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentingApp.Models
{
    public class Contract
    {
        public int idcontract { get; set; }
        public int idcar { get; set;}
        public int iduser { get; set; }
        public string customerName { get; set; }
        public DateTime rentDate { get; set; }
        public DateTime returnDate { get; set; }
        public DateTime contractDate { get; set; }
        public string customerPnc { get; set; }
        public double payment { get; set; }
        public bool finished { get; set; }
        public bool returned { get; set; }


    }
}