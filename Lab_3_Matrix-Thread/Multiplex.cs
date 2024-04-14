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
       public  Matrix result;
        public Matrix result_simple;
        int counter=0;
        //double time_thread=0;
       // double time_parallel=0;
        void Counter() { counter++; }
        public int get_counter() { return counter; }
        public static readonly object locker=new object();
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

        public void Count_matrix(int Threads_number,Label label_help)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();


           result = new Matrix(2,matrix_two.Size);

           Thread[] threads = new Thread[Threads_number];

            int elements_per_thread = (int)Math.Ceiling((double)(matrix_one.Size * matrix_one.Size) / Threads_number);

            for(int t=0;t<Threads_number;t++)
            {
                int start = t * elements_per_thread;
                int end = Math.Min((t+1) * elements_per_thread, (matrix_one.Size));




                threads[t] = new Thread(()=>Calculate(start,end,result,label_help));
                threads[t].Start();


              

            }


            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            watch.Stop();
            label_help.Text = watch.ElapsedMilliseconds.ToString();

             

        }


        public void Calculate(int start,int end,Matrix result,Label label_help)
        {
            lock(locker)
            {
                Counter();
            }
             

            for(int i=start; i<end; i++)
            {
                for(int j=0; j<matrix_one.Size; j++)
                {
                    double sum = 0;
                    for(int k=0; k<matrix_two.Size; k++)
                    {
                        sum += matrix_one.Values[i][k] * matrix_two.Values[k][j];
                    }
                    lock (locker) { result.Values[i][j] = sum; }
                   
                }
            }

           

        }

        public void Count_matrix_simple(int Threads_number,Label hel)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            result_simple = new Matrix(2, matrix_two.Size);

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


            watch.Stop();
            hel.Text = watch.ElapsedMilliseconds.ToString();
        

        }
    }
}
