using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n,c=0,b=1,x,x_1;
            Console.WriteLine("Введите количество элементов");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x ");
            x = int.Parse(Console.ReadLine());
            x_1 = x;
            double l;
            l = Math.Log((x + 1) / (x - 1));
            Console.WriteLine('\n');
            Console.WriteLine(l);
            for (int i = 0; i < n ; i++)
            {
                c = c + (1 / (b * x));
                x = x * x_1;
                x = x * x_1;
                b = b + 2;
            }
            c = c * 2;
            Console.WriteLine('\n');
            Console.WriteLine("{0:0.###########}",c);
        }


            /*
            static public void Sum(int S, int[] A, out int b)
            {
                b = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = A[i] + S;
                }

                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = A[i] * 2;
                    b += A[i];
                }
                Console.WriteLine('\n');

                Array.Resize(ref A, 10);

                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine(A[i]);
                }
            }

            */

            /*
                    static void Main(string[] args)
                    {
                        int[] A = new int[5];
                        for (int i = 0; i < A.Length; i++)
                        {
                            A[i] = int.Parse(Console.ReadLine());
                        }
                        int S = 20;
                        int b;

                        Sum(S, A, out b);
                        Console.WriteLine('\n');
                        Console.WriteLine(b);


                        int[] B = new int[5];

                        int[,] A = new int[4, 5];
                        for (int i = 0; i < A.GetLength(0); i++)
                        {
                            for (int j = 0; j < A.GetLength(1); j++)
                            {
                                Random rnd = new Random();
                                int value = rnd.Next(-50, 50);
                                A[i, j] = value;
                                //Console.Write("{0,4}", A[i, j]);
                                //Console.Write('\t');
                            }
                            //Console.Write('\n');
                        }
                        Console.WriteLine('\n');

                        int[][] B = new int[4][];
                        for (int i = 0; i < B.GetLength(0); i++)
                        {
                            B[i] = new int[5];            
                        }

                        for (int i = 0; i < B.Length; i++)
                        {
                            for (int j = 0; j < B.Length; j++)
                            {
                                Random rnd = new Random();
                                B[i][j] = rnd.Next(-10, 10);
                            }
                        }
                        foreach (var a in B)
                        {
                            foreach (var b in a)
                            {
                                Console.Write("{0,4}", b);
                                Console.Write('\t');
                            }
                            Console.Write('\n');
                        }
                        Console.Write('\n');
                        foreach (int a in A)
                        {
                            Console.Write("{0,4}", a);

                        }
                        foreach (var a in A) 
                        {
                            Console.Write("{0,4}", a);
                            Console.Write('\t');
                        }
                    }
                }
            */
    }
}
