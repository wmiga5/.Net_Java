using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Weather_api
{
    public class rate_data
    {

        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Exchange_rates rates { get; set; }
       public rate_data() { disclaimer = ""; }
    }
}
