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


        public Result(List<Item> x)
        {
            solved = x;
            foreach (Item Y in solved)
            {
                total_value += Y.value;
                total_weight += Y.weight;
            }
        }


        public override string ToString()
        {
            string result = $"Total_value{total_value};Total_weight{total_weight}\n";
            foreach (var item in solved)
            {
                result += $"Number:{item.index} {item}\n";
            }

            return result;
        }
    }
}
