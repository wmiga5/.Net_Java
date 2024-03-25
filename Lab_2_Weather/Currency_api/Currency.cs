using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_api
{
    internal class Currency
    {
       public int Id {  get; set; }
       public required string Tag {  get; set; }
       public required float Exchange {  get; set; }

        public required double timestamp_number {  get; set; }

       

        public Currency() { Id= 0; Tag = "NON";Exchange = -1;timestamp_number = 0; }
        public Currency(int id,string tag,float exchange,double time) { Id = id; Tag = tag; Exchange = exchange;timestamp_number = time; }
        public override string ToString()
        {
            return $"{Tag},\t:{Exchange}\n";
        }
    }
}
