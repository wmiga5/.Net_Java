using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Problem
    {
        int number;
        int seed;
        List<Item> results;

        public Problem(int n,int s)
            { number = n; seed = s;
           
            results = new List<Item>();

            Random random = new Random(seed);

            for (int i=0;i<number;i++)
                 {
                    results.Add(new Item(random.Next(1, 11),random.Next(1, 11),i));
                 }
             }

        public override string ToString()
        {
            string result = "";
            foreach(var item in results)
            {
                result += $"Number:{item.index} {item}\n"; 
            }
            return result;
        }


        public List<Item> Solve(int Capacity)
        {
            List<Item> help = new List<Item>();
            results=results.OrderByDescending(Item=>(double)Item.value/Item.weight).ToList();
            int weight_left = Capacity;
            for(int i=0;i<results.Count();i++)
            {
                weight_left = weight_left - results[i].weight;
                if(weight_left >= 0)
                {
                    help.Add(results[i]);
                }
                else
                {
                    break;
                }
               
            }
            

            return help;
        }


    }
}
