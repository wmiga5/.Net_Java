using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Result
    {
        public int total_value;
      public  int total_weight;
       public List<Item> solved;
     
        
        public Result(List<Item> x) { total_value = 0;total_weight = 0; solved = x; }


        public override string ToString()
        {
            string result = "";
            foreach (var item in solved)
            {
                result += $"Number:{item.index} {item}\n";
            }
            return result;
        }
    }
}
