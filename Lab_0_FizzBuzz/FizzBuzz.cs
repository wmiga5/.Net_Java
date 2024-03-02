using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FizzBuzz
    {
        int upper_limit;
        public FizzBuzz(int x) { upper_limit = x; }
        public void DisplayAttribute()
        {
            for (int i = 1; i <= upper_limit; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }


    }
}
