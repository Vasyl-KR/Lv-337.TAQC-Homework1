using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            task2
            try
            {
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    a = reader.Read() - 48;
                    reader.Read();
                    b = reader.Read() - 48;
                }
                using (StreamWriter writer = new StreamWriter("rez.txt"))
                {
                    writer.Write(String.Format("{0} / {1} = {2}", a, b, DoubleResult(a, b)));
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            //task3
            DirectoryInfo info = new DirectoryInfo(@"D:\ArchiCAD\");
            FileInfo[] file = info.GetFiles();
            using (StreamWriter writer = new StreamWriter("DirectoryD.txt"))
            {
                foreach (FileInfo fs in file)
                {
                    writer.Write(String.Format("Name {0}, Size{1}, Type {2}", fs.Name, fs.Length, Path.GetExtension(fs.FullName)));
                    writer.WriteLine();
                }
            }

            //task4
            DirectoryInfo infoD = new DirectoryInfo(@"D:\SS\TAQC\C#\");
            FileInfo[] fileD = infoD.GetFiles("*.txt");

            foreach (FileInfo dri in fileD)
            {
                using (StreamReader reader = new StreamReader(dri.FullName))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }

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
