using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Person
    {
        int age;

        public Person(int age)
        {
            this.age = age;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person a = new Person(2);
            Person b = a;
                if (a == b)
                    Console.WriteLine("tes");
                else
                    Console.WriteLine("no");

            Console.ReadKey();

        }
    }
}
