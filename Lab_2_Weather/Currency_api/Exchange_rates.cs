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

        public float CHF { get; set; }
        public float EUR { get; set; }
        public float GBP { get; set; }
        public float JPY { get; set; }
        public float PLN { get; set; }
        public float RUB { get; set; }
        public float USD { get; set; }


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
