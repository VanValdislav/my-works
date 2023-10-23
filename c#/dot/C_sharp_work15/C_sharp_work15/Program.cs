using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_work15
{
    internal class Program
    {
        static public Array Array(int[]A,int[]B) 
        {
            int v;
            for (int k = 0; k < A.Length; k++)
            {
                if (B[k]<0)
                {
                    v = A[k] + 1;
                    A[k] = v;
                }
                if (B[k]==0)
                {
                    continue;
                }
                if (B[k]>0)
                {
                    v = A[k] - 1;
                    A[k] = v;
                }
            }
            return A;
        }
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Введите размер массива");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];
            Console.WriteLine("заполним массив A");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("заполним массив B");
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }
            Array(A,B);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            int end;
            end = int.Parse(Console.ReadLine());
        }
    }
}
