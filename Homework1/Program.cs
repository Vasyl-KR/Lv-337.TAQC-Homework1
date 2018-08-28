using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two integer numbers");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("a+b = {0}\na-b = {1}\na*b = {2}\na/b = {3}", a + b, a - b, a * b, a / b);

            Console.ReadKey();

        }
    }
}
