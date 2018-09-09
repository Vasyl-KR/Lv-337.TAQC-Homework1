using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Vasyl\Source\Repos\Lv-337.TAQC-Homeworks\Homework8-2\data.txt";
            string[] code = File.ReadAllLines(path);

            int count = 0;
            foreach (string s in code)
            {
                count++;
                Console.WriteLine("Line №{0} has {1} symbols", count, s.Length);
            }
            int countMax = 0, countMin = 0;
            string shortest = code[0], longest = code[0];
            count = 0;
            foreach (string s in code)
            {
                count++;
                if (s.Length != 0)
                {
                    if (shortest.Length >= s.Length)
                    {
                        shortest = s;
                        countMin = count;
                    }
                }
                if (longest.Length <= s.Length)
                {
                    longest = s;
                    countMax = count;
                }

            }
            Console.WriteLine("The shortest line №{0} has {1} symbols\n{2}\nThe longest line №{3} has {4} symbols\n{5}",
                countMin, shortest.Length, shortest, countMax, longest.Length, longest);

            Console.WriteLine("\nLines with \"var\"");

            foreach (string s in code)
            {
                if (s.Contains("var"))
                {
                    Console.WriteLine(s);
                }
            }


            Console.ReadKey();
        }
    }
}
