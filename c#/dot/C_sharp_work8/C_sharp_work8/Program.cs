using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_work8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            int n,n_1,count = 0;

            string Str = Console.ReadLine();
            string Str_2 = Str.Replace(":", "");
            n = Str.Length;
            n_1 = Str_2.Length;
            count = n - n_1;
            Console.WriteLine(Str_2);
            Console.WriteLine("\nУдалено {0} символов", count);
            string k = Console.ReadLine();
        }
    }
}
