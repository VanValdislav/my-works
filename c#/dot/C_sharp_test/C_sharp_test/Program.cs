using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_test
{
    internal class Program
    {
        static string Str(out string stroka, char n)
        {
            Console.WriteLine("Введите строку:");
            stroka = Console.ReadLine();
            char zam = n;
            int len = stroka.Length;
            char[] Array = new char[len];
            stroka.CopyTo(0, Array, 0, len);
            stroka = "";
            for (int i = 0; i < len; i++)
            {
                if (i % 2 != 0) { 
                   
                    Array[i] = zam;
                }
            }
            for (int i = 0; i < len; i++)
            {
                stroka = stroka + Array[i];
            }
            return (stroka);
        }
        static void Main(string[] args)
        {
            char n;
            Console.WriteLine("Ввежите символ:");
            n = char.Parse(Console.ReadLine());
            string stroka;
            Random r = new Random();
            Str(out stroka, n);
            Console.WriteLine(stroka);

            //long[,] B = new long[2 * n, 2 * n];
            //long[,] A = new long[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        B[i, j] = r.Next(-100, 100);
            //        B[i, (j + n)] = r.Next(-100, 100);
            //        B[(i + n), j] = r.Next(-100, 100);
            //        B[(i + n), (j + n)] = r.Next(-100, 100);
            //    }
            //}

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    for (int j = 0; j < 2 * n; j++)
            //    {
            //        Console.Write("{0,5}", B[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        A[i, j] = B[i, j];
            //        B[i, j] = B[i + n, j + n];
            //        B[i + n, j + n] = A[i, j];

            //        A[i, j] = B[i + n, j];
            //        B[i + n, j] = B[i, j + n];
            //        B[i, j + n] = A[i , j];

            //    }
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 2 * n; i++)
            //{
            //    for (int j = 0; j < 2 * n; j++)
            //    {
            //        Console.Write("{0,5}", B[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
 }
