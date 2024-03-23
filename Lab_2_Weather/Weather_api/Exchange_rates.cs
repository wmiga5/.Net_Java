using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Weather_api
{


    public class Exchange_rates
    {

        public double CHF { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double JPY { get; set; }
        public double PLN { get; set; }
        public double RUB { get; set; }
        public int USD { get; set; }


        public override string ToString()
        {
            return $"CHF:{CHF}\n" +
                $"EUR:{EUR}\n" +
                $"GBP:{GBP}\n" +
                $"JPY:{JPY}\n" +
                $"PLN:{PLN}\n" +
                $"RUB:{RUB}\n" +
                $"USD:{USD}\n" ;
        }

    }


    



}
