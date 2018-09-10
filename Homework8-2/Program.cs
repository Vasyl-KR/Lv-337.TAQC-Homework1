using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
B) Create Console Application project.
   Prepare txt file with a lot of text inside (for example take you .cs file from previos homework)
   Read all lines of text from file into array of strings.
   Each array item contains one line from file.
   Complete next tasks:
   1) Count and write the number of symbols in every line.
   2) Find the longest and the shortest line. 
   3) Find and write only lines, which consist of word "var"
*/


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

            var max = code.Select(s => s.Length).Max();
            var min = code.Select(s => s.Length).Min();

            Console.WriteLine("The longest line - {0}, has {1} symbols", code.FirstOrDefault(s => s.Length == max),max);
            Console.WriteLine("The shortest line - {0}, has {1} symbols", code.FirstOrDefault(s => s.Length == min),min);

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
