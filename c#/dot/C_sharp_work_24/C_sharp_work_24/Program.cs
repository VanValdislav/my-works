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
            string k = "";
            string path = @"C:\Users\fona1\OneDrive\Рабочий стол\fale_tex.txt";
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                file.Seek(0, SeekOrigin.End);
                using (StreamWriter stream = new StreamWriter(file))
                {
                    string str = Console.ReadLine();
                    stream.Write(" " +str);

                }
            }
            using (StreamReader stream1 = File.OpenText(path))
            {
                k = stream1.ReadLine();
            }
            string temp = Console.ReadLine();
            String[] words = k.Split(new char[] { ' ', ',' });

            int counter = 0;

            foreach (var word in words)
            {
                if (temp == word.ToLower())
                    counter++;
            }

            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
