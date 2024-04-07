using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_Thread
{
    public class Matrix
    {
        public int Size { get; set; }
        public List<List<double>> Values { get; set; }

        public Matrix()
        {
            Size = 0;
            Values = new List<List<double>>();
        }

        public Matrix(int seed, int size)
        {
            Size = size;
            Values = new List<List<double>>();
            Random random = new Random(seed);

            for (int i = 0; i < Size; i++)
            {
                List<double> row = new List<double>();
                for (int j = 0; j < Size; j++)
                {
                    row.Add(random.Next(0, 10));
                }
                Values.Add(row);
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (List<double> wiersz in Values)
            {   
                foreach (double wier in wiersz)
                {
                    result += wier+" ";
                }
                result += '\n';
            }
            return result;
        }
    }
}
