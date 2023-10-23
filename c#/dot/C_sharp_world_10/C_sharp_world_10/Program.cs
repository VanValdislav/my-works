using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_world_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str,strout="";int len,count = 0,t = 0;
            str = Console.ReadLine();
            len = str.Length;
            char[] Arrey = new char[len];
            str.CopyTo(0, Arrey, 0, len);
            for (int i = 1; i < len - 1; i++)
            {
                if (char.IsDigit(Arrey[i]) && (char.IsLetter(Arrey[i-1])||char.IsWhiteSpace(Arrey[i-1])))
                {
                    t++;
                }
                if (t == 1)
                { 
                    if (char.IsDigit(Arrey[i]))
                    {
                        if (Arrey[i] == '0')
                        {
                            count++;
                        }
                        strout = strout + Arrey[i];
                    }
                    if (char.IsWhiteSpace(Arrey[i]))
                    {
                        strout = "";
                        count = 0;
                    }
                    if (char.IsLetter(Arrey[i]))
                    {
                        if (count > 3)
                        {
                            strout = "";
                            count = 0;
                            
                        }
                        else
                        {
                            Console.WriteLine(strout);
                            strout = "";
                        }
                        t = 0;
                    }
                    
                }

            }
            
            int END;
            END = Console.ReadLine().Length;
        }
    }
}
