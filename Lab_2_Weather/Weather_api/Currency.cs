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

       

        public Currency() { Id= 0; Tag = "NON";Exchange = -1; }
        public Currency(int id,string tag,float exchange) { Id = id; Tag = tag; Exchange = exchange; }
        public override string ToString()
        {
            return $"{Tag},\t:{Exchange}\n";
        }
    }
}
