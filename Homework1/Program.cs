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
            for (int i = a; i <= b ; i++)
            {

            }

            Console.ReadKey();

        }
    }
}
