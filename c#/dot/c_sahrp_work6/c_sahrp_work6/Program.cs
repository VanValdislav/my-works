using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sahrp_work6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n,n_1;
            Console.WriteLine("Введите число n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            n_1 = n;
            int[,] B = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n-i; j++)
            //    {
            //        B[i, j] = i+1;
            //    }

            //}
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        B[i, j] = 1;
                    }
                    if (i == n - 1) 
                    {
                        B[i, j] = 1;
                    }
                    if (j==0)
                    {
                        B[i, j] = 1;
                    }
                    if (j==n-1)
                    {
                        B[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", B[i, j]);
                    Console.Write('\t');
                }
                Console.Write('\n');
            }
        }
    }
}
