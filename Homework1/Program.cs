using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create Console Application project in VS.
In method Main() write code for solving next tasks:

1) Define integer variables a and b.Read values a and b from Console and calculate: a+b, a-b, a*b, a/b. Output obtained results.

2) Output question “How are you?“. Define string variable answer. Read the value answer and output: “You are (answer)". 

3) Read 3 variables of char type. Write message: “You enter (first char), (second char), (3 char)”

4) Enter 2 integer numbers. Check if they are both positive – use bool expretion*/

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

            Console.WriteLine("Enter two integer numbers");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine(a > 0 && b > 0 ? "Positive" : "Negative");
            
            Console.ReadKey();

        }
    }
}
