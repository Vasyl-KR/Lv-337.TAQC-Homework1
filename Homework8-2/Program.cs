using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Create Console Application project.
A) Use classes Shape, Circle, Square from your previous homework.
   Use Linq and string functions to complete next tasks:
   1) Create list of Shape and fill it with 6 different shapes (Circle and Square).
   2) Find and write into the file shapes with area from range [10,100]
   3) Find and write into the file shapes which name contains letter 'a'
   4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 

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
