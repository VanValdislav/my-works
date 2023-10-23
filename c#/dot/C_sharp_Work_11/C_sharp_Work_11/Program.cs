using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Work_11
{
    internal class Program
    {
        static public Array Array(int[]A) 
        {
            int min=Math.Abs(A[0]);
            for (int i = 0; i < A.Length-1; i++)
            {
                if (min>Math.Abs(A[i+1]))
                {
                    min = A[i + 1];
                }
            }
            for (int i = 0; i < A.Length; i+=2)
            {
                
                A[i] = min;
                
            }
            return (A);
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите размер массива");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("заполним массив");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Array(A);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            int end;
            end = Console.ReadLine().Length;
        }
    }
}
