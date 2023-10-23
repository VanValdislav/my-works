using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_work14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            bool b = false;
            string resStr = string.Empty;
            for (int i =0;i<n;i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <n;i++)
            {
                if (mas[i] == 0)
                {
                    b = true;
                }
                if (b == true)
                { 
                    resStr += Convert.ToString(mas[i]);
                }
            }
            Console.WriteLine(resStr);
            Console.ReadKey();

            //int a = 453021;
            //string s = a.ToString(), resStr = string.Empty;
            //foreach (char c in s)
            //{
            //    if (c == '0')
            //    {
            //        b = true;
            //    }
            //    if (b == true) resStr += c;
            //}
            //Console.WriteLine(resStr);
            //Console.ReadKey();

            //int n ;
            //Console.WriteLine("Введите количество участников");
            //n = int.Parse(Console.ReadLine());
            //float[] A = new float[n];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = float.Parse(Console.ReadLine());
            //}
            //Array.Sort(A);
            //if (n <= 6)
            //{
            //    for (int i = 0; i < A.Length; i++)
            //    {
            //        Console.Write(A[i] + " ");
            //    }
            //}
            //else 
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.Write(A[i] + " ");
            //    }
            //}
            //int end;
            //end = int.Parse(Console.ReadLine());
        }
    }
}
