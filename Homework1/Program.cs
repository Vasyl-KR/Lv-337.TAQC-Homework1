using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*a) Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
  b) Ask user to enter the number of month. Read the value and write the amount of days in this month.
  c) Enter 10 integer numbers. Calculate the sum of first 5 elements 
  if they are positive or product of last 5 element in  the other case.*/

namespace Homework3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //task 1
            int count_a = 0, count_o = 0, count_i = 0, count_e = 0;
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                switch (ch)
                {
                    case 'a':
                        count_a++;
                        break;
                    case 'o':
                        count_o++;
                        break;
                    case 'i':
                        count_i++;
                        break;
                    case 'e':
                        count_e++;
                        break;
                }
            }
            Console.WriteLine("a-{0} o-{1} i-{2} e-{3}", count_a, count_o, count_i, count_e);
            //task 2
            Console.WriteLine("Enter the number of month");
            int month;
            Int32.TryParse(Console.ReadLine(), out month);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("The amount of days in this month - 31");
                    break;
                case 2:
                    Console.WriteLine("The amount of days in this month - 28");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("The amount of days in this month - 30");
                    break;
                default:
                    Console.WriteLine("Not a month");
                    break;
            }
            //task3
            int[] Numbers = new int[10];
            bool check = true;
            int result = 0;
            Console.WriteLine("Enter 10 integer numbers");
            for (int i = 0; i < 10; i++)
            {
                Int32.TryParse(Console.ReadLine(), out Numbers[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                if (Numbers[i] < 0)
                {
                    check = false;
                }
            }
            if (check)
            {
                for (int i = 0; i < 5; i++)
                {
                    result += Numbers[i];
                }
                Console.WriteLine("The sum of first 5 elements = {0}", result);
            }
            else
            {
                result = 1;
                for (int i = 5; i < 10; i++)
                {
                    result *= Numbers[i];
                }
                Console.WriteLine("The product of last 5 element = {0}", result);
            }

            Console.ReadKey();

        }
    }
}
