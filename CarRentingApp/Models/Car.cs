using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentingApp.Models
{
    public class Car
    {
        public int idcar { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string location { get; set; }
        public DateTime year { get; set; }
        public double engine { get; set; }
        public string fuel { get; set; }
        public byte[] photo { get; set; }
        public int imageSize { get; set; }
    }
}