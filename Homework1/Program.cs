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
            //task 1
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
            Console.WriteLine(count);
            //task 2
            Console.WriteLine("Enter string line");
            string line = Console.ReadLine();
            int count2 = 0;
            foreach (char c in line)
            {
                if (count2 % 2 == 0)
                {
                    Console.Write(c);
                }
                count2++;
            }
            Console.WriteLine();
            //task 3
            Console.WriteLine("Enter name of drink");
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "coffee":
                    Console.WriteLine(drink + " 3$");
                    break;
                case "tea":
                    Console.WriteLine(drink + " 2$");
                    break;
                case "juice":
                    Console.WriteLine(drink + " 1.5$");
                    break;
                case "water":
                    Console.WriteLine(drink + " 1$");
                    break;
                default:
                    Console.WriteLine("It's not a drink");
                    break;
            }
            //task 4
            double sum = 0;
            int number = 0, count3 = -1;
            Console.WriteLine("Enter numbers");
            do
            {
                sum += number;
                count3++;
                Int32.TryParse(Console.ReadLine(), out number);
            }
            while (number >= 0);
            Console.WriteLine("Arithmetic mean {0}", sum / count3);
            //task 5
            Console.WriteLine("Enter year");
            int year;
            Int32.TryParse(Console.ReadLine(), out year);
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("{0} is leap year", year);
            else
                Console.WriteLine("{0} is not leap year", year);
            //task 6
            int sum2 = 0;
            Console.WriteLine("Enter number");
            string sNumber = Console.ReadLine();
            foreach (char ch in sNumber)
            {
                sum2 += Convert.ToInt32(ch) - 48;
            }
            Console.WriteLine(sum2);
            //task 7
            Console.WriteLine("Enter number");
            bool check = true;
            string sNumber2 = Console.ReadLine();
            foreach (char ch in sNumber2)
            {
                if ((Convert.ToInt32(ch) - 48) % 2 == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("Odd digits");
            }
            else
            {
                Console.WriteLine("Even digit");
            }

            Console.ReadKey();

        }
    }
}
