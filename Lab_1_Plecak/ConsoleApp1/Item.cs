using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Item
    {
        public int weight;
         public int value;
       public int index;
        public Item() { weight = -1;value = 0; }
        public Item(int x, int y,int z) { weight = x;value = y;index = z; }

        public override string ToString()
        {
            return "v: " + value + "  w: " + weight; 
        }
    }
}
