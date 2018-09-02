using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create Console Application project in VS.
   In method Main() write code for solving next task:
        a) read 3 float numbers and check: are they all belong to the range [-5,5].
        b) read 3 integers and write max and min of them.
        c) read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
        d) declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type and read values for it. 
        Output myDos into console. (Declare method ToString in struct)
*/
namespace Homework2
{
    enum HTTPError { BadRequest = 400, Unauthorized, PaymentRequired, Forbidden, NotFound, MethodNotAllowed }

    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return String.Format("Name {0}\nMark {1}\nAge {2}", name, mark, age);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Enter 3 float numbers");
            float.TryParse(Console.ReadLine(), out a);
            float.TryParse(Console.ReadLine(), out b);
            float.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Are they all belong to the range [-5,5]? \n{0}", (a >= -5 &&
                a <= 5) ? (b >= -5 && b <= 5) ? (c >= -5 && c <= 5) ? "true" : "false" : "false" : "false");

            int m, n, v;
            Console.WriteLine("Enter 3 integer numbers");
            Int32.TryParse(Console.ReadLine(), out m);
            Int32.TryParse(Console.ReadLine(), out n);
            Int32.TryParse(Console.ReadLine(), out v);
            Console.WriteLine("Max {0}", (m > n) ? (m > v) ? m : v : (n > v) ? n : v);
            Console.WriteLine("Min {0}", (m < n) ? (m < v) ? m : v : (n < v) ? n : v);

            Console.WriteLine("Enter number of HTTP error");
            Console.WriteLine(((HTTPError)Int32.Parse(Console.ReadLine())).ToString());

            Dog myDog;
            Console.WriteLine("Enter name, mark and age of your dog");
            myDog.name = Console.ReadLine();
            myDog.mark = Console.ReadLine();
            Int32.TryParse(Console.ReadLine(), out myDog.age);
            Console.WriteLine(myDog.ToString());

            Console.ReadKey();
        }
    }
}
