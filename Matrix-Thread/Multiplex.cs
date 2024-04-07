using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix_Thread
{
    internal class Multiplex
    {
        Matrix matrix_one;
        Matrix matrix_two;

        public Multiplex()
        {
            matrix_one = new Matrix();
            matrix_two = new Matrix();
        }
        public Multiplex(Matrix matrix_one, Matrix matrix_two)
        {
            this.matrix_one = matrix_one;
            this.matrix_two = matrix_two;
        }

        public Matrix Count_matrix(int Threads_number)
        {
            Matrix result = new Matrix(2,matrix_two.Size);

            List<Thread> threads = new List<Thread>();

            int elements_per_thread = (int)Math.Ceiling((double)(matrix_one.Size * matrix_one.Size) / Threads_number);

            for(int t=0;t<Threads_number;t++)
            {
                int start = t * elements_per_thread;
                int end = Math.Min((t+1) * elements_per_thread, matrix_one.Size * matrix_one.Size);

                for (int idx = start; idx < end; idx++)
                {
                    int row = idx / matrix_one.Size;
                    int col = idx % matrix_one.Size;

                    Thread thread = new Thread(obj =>
                     {
                    
                    
                    double sum = 0;
                    for (int k = 0; k < matrix_one.Size; k++)
                    {
                        sum += matrix_one.Values[row][k] * matrix_two.Values[k][col];
                    }
                    result.Values[row][col] = sum;

                     });
                    threads.Add(thread);
                    thread.Start();



                }

                
            }


            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            return result;

        }

        public Matrix Count_matrix_simple(int Threads_number)
        {
            Matrix result = new Matrix(2, matrix_two.Size);




            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism =Threads_number
            };



            Parallel.For(0, matrix_one.Size,opt, obj =>
            {
            for (int idx = 0; idx < matrix_one.Size; idx++)
                {
                   
                        double sum = 0;
                        for (int k = 0; k < matrix_one.Size; k++)
                        {
                            sum += matrix_one.Values[obj][k] * matrix_two.Values[k][idx];
                        }
                    result.Values[obj][idx] = sum;
                }
            });





        

            return result;

        }
    }
}
