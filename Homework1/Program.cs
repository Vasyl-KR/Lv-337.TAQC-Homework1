using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter 2 integer numbers");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Enter string line");
            string s = Console.ReadLine();
            count = 0;
            foreach (char c in s)
            {
                if(count % 2 == 0)
                {
                    Console.Write(c);
                }
                count++;
            }

            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
