using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentingApp.Models
{
    public class User
    {
        public int iduser { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public int type { get; set; }
    }
}