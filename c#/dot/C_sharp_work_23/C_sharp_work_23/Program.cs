using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_work_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k="";
            string path = @"C:\Users\fona1\OneDrive\Рабочий стол\fale_A.txt";
            string pathB = @"C:\Users\fona1\OneDrive\Рабочий стол\fale_B.txt";
            int size = int.Parse(Console.ReadLine());
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                file.Seek(0, SeekOrigin.End);
                using (StreamWriter stream = new StreamWriter(file))
                {
                    Random rnd = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        int value = rnd.Next(-50, 50);
                        stream.Write(value + " ");
                    }

                }
            }
            using (StreamReader stream1 = File.OpenText(path)) 
            {
                k = stream1.ReadLine();
            }
            string[] vs = new string[size];
            vs = k.Split(' ');
            using (FileStream file = new FileStream(pathB, FileMode.Append))
            {
                file.Seek(0, SeekOrigin.End);
                using (StreamWriter stream = new StreamWriter(file))
                {
                    int m = int.Parse(Console.ReadLine());
                    int n = int.Parse(Console.ReadLine());
                    for (int ind = 0; ind < size; ind++)
                    {
                        //Console.WriteLine(vs[ind]);
                        int j = Convert.ToInt32(vs[ind]);
                        if (j%m==0 && j%n!=0)
                        {
                            stream.Write(j + " ");
                        }

                    }
                }
            }
        }
    }
}
