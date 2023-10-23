using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x_start, x_end, dx,F, a, b, c, i_1,x;
            Console.WriteLine("x_start",'\n') ;
            x_start = float.Parse(Console.ReadLine());
            Console.WriteLine("x_end",'\n');
            x_end = float.Parse(Console.ReadLine());
            Console.WriteLine("dx",'\n');
            dx = float.Parse(Console.ReadLine());
            Console.WriteLine("a",'\n');
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b",'\n');
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("c",'\n');
            c = float.Parse(Console.ReadLine());
            i_1 = (x_end - x_start) / dx;
            if (a != 0 && (b != 0 || c != 0) && (a%1==0) && (b % 1 == 0) && (c % 1 == 0))
            { 
                x = x_start;
                if (a < 0 && c != 0)
                {
                    for (int i = 0; i < i_1; i++)
                    {
                        F = (float)(a * x * x + b * x + c);
                        Console.WriteLine("{0} {1}", "x = " + x, "F = " + F);
                        x += dx;
                        
                    }
                }
                if (a > 0 && c == 0)
                {
                    for (int i = 0; i < i_1; i++)
                    {
                        if ((x - c) != 0)
                        {
                            F = (float)(-a / (x - c));
                            Console.WriteLine("{0} {1}", "x = " + x, "F = " + F);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", "x = " + x, "F = Не определено");
                        }
                        x += dx;
                    }
                }
                else
                {
                    for (int i = 0; i < i_1; i++)
                    {
                        F = (float)(a * (x + c));
                        Console.WriteLine("{0} {1}","x = " + x,"F = "+ F);
                        x += dx;
                    }
                }
            }
            else 
            {
                float x_1;
                x = (int)x_start+1;
                x_1 = x;
                if (a < 0 && c != 0)
                {
                    for (int i = 0; i < i_1; i++)
                    {

                        F = a * x_1 * x_1 + b * x_1 + c;
                        Console.WriteLine("{0} {1}", "x = " + x_1, "F = " + F);
                        x += dx;
                        x_1 = (int)x;
                    }
                }
                if (a > 0 && c == 0)
                {
                    for (int i = 0; i < i_1; i++)
                    {
                        if ((x_1 - c) == 0)
                        {
                            F = (-a / (x_1 - c));
                            Console.WriteLine("{0} {1}", "x = " + x_1, "F = " + F);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", "x = " + x, "F = Не определено");
                        }
                        x += dx;
                        x_1 = (int)x;
                    }
                }
                else
                {
                    for (int i = 0; i < i_1; i++)
                    {
                        F = a * (x_1 + c);
                        Console.WriteLine("{0} {1}", "x = " + x_1, "F = " + F);
                        x += dx;
                        x_1 = (int)x;
                    }
                }

            }
           
        }
    }
}
