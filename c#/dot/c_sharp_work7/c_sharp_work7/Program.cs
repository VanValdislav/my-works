using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_work7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m,s,t,str = 0,stol = 0;
            Random rnd = new Random();
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int value = rnd.Next(-50, 50);
                    A[i, j] = value;
                    Console.Write("{0,4}", A[i, j]);
                    Console.Write('\t');
                }
                Console.Write('\n');
            }
            Console.Write('\n');
            s = A[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m-1; j++)
                {
                    if (s<A[i,j+1])
                    {
                        str = i;
                        stol = j+1;
                    }
 
                }
            }
            //Столбик
            for (int q = 0; q < n; q++)
            {
                t = A[q, 0];
                A[q, 0] = A[q, stol];
                A[q, stol] = t;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", A[i, j]);
                    Console.Write('\t');
                }
                Console.Write('\n');
            }
            Console.Write('\n');
            //строка
            for (int w = 0; w < m; w++)
            {
                t = A[0, w];
                A[0, w] = A[str, w];
                A[str, w] = t;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", A[i, j]);
                    Console.Write('\t');
                }
                Console.Write('\n');
            }
            int end;
            end = int.Parse(Console.ReadLine());
        }
    }
}
