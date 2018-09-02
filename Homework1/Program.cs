using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Input two integer numbers a  and b and check whether they have the same parity (true or false)
 
  Input the real number r and calculate the circle circumference, circle area and the sphere volume of this radius

  Input two integer numbers h and m, representing the time (hour and minute). 
  Depending on the time, output the greeting (“Good morning!”, “Good afternoon!”, “Good evening!”, “Good night!”)
*/
namespace Homework2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int day, month;
            Console.WriteLine("Enter a day");
            Int32.TryParse(Console.ReadLine(), out day);
            Console.WriteLine("Enter a month");
            Int32.TryParse(Console.ReadLine(), out month);
            bool check = day > 0 && day <= 31 && month > 0 && month <= 12;
            Console.WriteLine(check);

            double number;
            Console.WriteLine("Enter a double number");
            Double.TryParse(Console.ReadLine(), out number);
            number *= 10;
            double a = (int)number % 10;
            number *= 10;
            double b = (int)number % 100 % 10;
            Console.WriteLine("First digit {0}, second digit {1}, sum {2}", a, b, a + b);

            int h;
            Console.WriteLine("Enter a hour");
            Int32.TryParse(Console.ReadLine(), out h);
            Console.WriteLine(h >= 0 ? h >= 6 ? h >= 12 ? h >= 18 ? h >= 24 ? "Too large number" : "Доброго вечора!" :
                "Доброго дня!" : "Доброго ранку!" : "Доброї ночi!" : "Can't be negative");

            Console.ReadKey();

        }
    }
}
