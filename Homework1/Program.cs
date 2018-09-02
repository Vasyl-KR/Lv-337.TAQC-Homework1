using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create Console Application project in VS.
In method Main() write code for solving next tasks:
	b) define integer variable a. Read the value of a from console and calculate area 
    and perimetr of square with length a. Output obtained results.
	c) define string variable name and integer value age. Output question "What is your name?";
    Read the value name and output next question: "How old are you,(name)?". Read age and write whole information  
    d) Read double number r and calculate the length (l=2*pi*r), area (S=pi*r*r) 
    and volume (4/3*pi*r*r*r) of a circle of given r */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a integer number a");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Perimeter = {0}\t Area = {1}", 4 * a, a * a);

            int age;
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0}?", name);
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Name - {0}, Age - {1}", name, age);

            double r;
            Console.WriteLine("Enter double number r");
            Double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Length - {0:F3}, Area - {1:F3}, Volume - {2:F3}", 2 * Math.PI * r, Math.PI * r * r, 4 / 3 * Math.PI * r * r * r);

            Console.ReadKey();

        }
    }
}
