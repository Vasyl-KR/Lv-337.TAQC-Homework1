using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ввести два цілих числа day та month і перевірити чи можуть вони представляти день та місяць. Вивести true чи false
 
  Ввести дійсне число  number і отримати 2 перші цифри після коми цього числа. Вивести суму цих цифр. Напр.: 3.456->4+5=9

  Ввести ціле число h , які представляють час доби (година ). 
  Залежності від часу доби вивести привітання («Доброго ранку!», «Доброго дня!», «Доброго вечора!», «Доброї ночі!»)

*/
namespace Homework2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //task1
            int day, month;
            Console.WriteLine("Enter a day");
            Int32.TryParse(Console.ReadLine(), out day);
            Console.WriteLine("Enter a month");
            Int32.TryParse(Console.ReadLine(), out month);
            bool check = day > 0 && day <= 31 && month > 0 && month <= 12;
            Console.WriteLine(check);
            //task2
            double number;
            Console.WriteLine("Enter a double number");
            Double.TryParse(Console.ReadLine(), out number);
            number *= 10;
            double a = (int)number % 10;
            number *= 10;
            double b = (int)number % 100 % 10;
            Console.WriteLine("First digit {0}, second digit {1}, sum {2}", a, b, a + b);
            //task3
            int h;
            Console.WriteLine("Enter a hour");
            Int32.TryParse(Console.ReadLine(), out h);
            Console.WriteLine(h >= 0 ? h >= 6 ? h >= 12 ? h >= 18 ? h >= 24 ? "Too large number" : "Доброго вечора!" :
                "Доброго дня!" : "Доброго ранку!" : "Доброї ночi!" : "Can't be negative");

            Console.ReadKey();

        }
    }
}
