﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculator sq = new Calculator();
            Console.WriteLine(sq.Square(12));
            Console.WriteLine(sq.Add(8, 63));
            Console.WriteLine(sq.Multiply(5, 8));
            Console.WriteLine(sq.Subtract(10, 42));
            Console.WriteLine(sq.Division(3, 4));

            Console.ReadKey();
        }
    }
}
