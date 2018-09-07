﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Утворити і заповнити колекцію з 10 цілих чисел
    Отримати і вивести на консоль тільки від’ємні числа
    Отримати і вивести на консоль тільки додатні парні числа
    Отримати найбільший та найменший елементи з масиву, а також суму всіх елементів.
    Отримати перший елемент з масиву, який є менший ніж середнє арифметичне значення елементів масиву
    Посортувати масив з використанням OrderBy*/


namespace Homework8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //task 1
            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rand.Next(-100, 100));
            }
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //task 2
            var negative = from i in numbers
                           where i < 0
                           select i;

            Console.WriteLine("Negative");
            foreach (var i in negative)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //task 3
            var positiveEqual = from i in numbers
                                 where i > 0 && i % 2 == 0
                                 select i;

            Console.WriteLine("Positive and Equal");
            foreach (var i in positiveEqual)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //task 4
            var min = (from x in numbers select x).Min();
            var max = (from x in numbers select x).Max();
            var sum = (from x in numbers select x).Sum();

            Console.WriteLine("Min {0} Max {1} Sum {2}", min, max, sum);
           
            //task 5
            var average = (from x in numbers select x).Average();
            var first = (from x in numbers where x < average select x).First();
            Console.WriteLine("Average {0} First {1}", average, first);

            //task 6
            var sort = from x in numbers
                       orderby x
                       select x;

            Console.WriteLine("Sorted");
            foreach (var i in sort)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();

        }
    }
}
