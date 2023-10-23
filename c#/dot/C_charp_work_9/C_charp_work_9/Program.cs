using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_charp_work_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray_1 = str.ToCharArray();
            char temp = ' ';
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i];
                count = str.ToCharArray().Where(j => j == temp).Count();
                if (count>1)
                {
                    for (int j = i+1; j < str.Length; j++)
                    {
                        if (charArray_1[i]==charArray_1[j])
                        {
                            charArray_1[j] = '*';
                        }
                    }

                }
            }
            Console.WriteLine(charArray_1);

        }
    }
}
