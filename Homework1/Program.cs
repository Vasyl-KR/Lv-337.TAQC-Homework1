using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Create method Div(), which calculates the dividing of two  double numbers. 
    In Main input  2 double numbers and call this method. Catch appropriative exceptions. 

    Read and write all data in task1 from data.txt into rez.txt files, by using (Catch appropriative exceptions):
        1. StreamReader StreamWriter
        2. File.WriteAllText
    Write into file ‘DirectoryC.txt’ information (name, type, size) 
    about all directories and files from disc C on your computer. Catch appropriative exceptions.

    Select from directory D only .txt files and print the text from it into console. 
    Catch appropriative exceptions.
*/


namespace Homework6
{
    class Program
    {

        static void Main()
        {
            //task1
            double a, b;
            try
            {
                Console.WriteLine("Enter two numbers");
                a = Double.Parse(Console.ReadLine());
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", a, b, DoubleResult(a, b));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid double number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is not allowed");
            }

            //task2


            Console.ReadKey();
        }
        static public double DoubleResult(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (a / b);
        }
    }
}
