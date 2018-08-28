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
            c
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("a+b = {0}\na-b = {1}\na*b = {2}\na/b = {3}", a + b, a - b, a * b, a / b);

            string answer;
            Console.WriteLine("How are you?");
            answer = Console.ReadLine();
            Console.WriteLine("You are {0}", answer);

            char c1, c2, c3;
            Console.WriteLine("Enter tree chars");
            char.TryParse(Console.ReadLine(), out c1);
            char.TryParse(Console.ReadLine(), out c2);
            char.TryParse(Console.ReadLine(), out c3);
            Console.WriteLine("You enter {0}, {1}, {2}", c1, c2, c3);

            Console.ReadKey();

        }
    }
}
