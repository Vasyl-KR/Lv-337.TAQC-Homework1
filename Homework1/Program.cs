using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Circle("Circle1", 5));
            figures.Add(new Circle("Circle2", 2.34));
            figures.Add(new Square("Square1", 1.18));
            figures.Add(new Square("Square2", 2.5));
            figures.Add(new Circle("Circle3", 7));
            figures.Add(new Square("Square3", 1));

            var selectedRange = from f in figures
                                where f.Area() > 10 && f.Area() < 100
                                select f;
            var selectedNames = from f in figures
                                where f.Name.Contains('a')
                                select f;
            using (StreamWriter sw = new StreamWriter("List.txt"))
            {
                sw.WriteLine("Shapes with area from range [10,100]");
                foreach (var o in selectedRange)
                {
                    sw.WriteLine("Name - {0}, Area - {1:F3}, Perimeter - {2:F3}", o.Name, o.Area(), o.Perimeter());
                }
                sw.WriteLine("Shapes which name contains letter 'a'");
                foreach (var o in selectedNames)
                {
                    sw.WriteLine("Name - {0}, Area - {1:F3}, Perimeter - {2:F3}", o.Name, o.Area(), o.Perimeter());
                }
            }
            figures.RemoveAll(x => x.Perimeter() < 5);
            foreach (var o in figures)
            {
                Console.WriteLine("Name - {0}, Area - {1:F3}, Perimeter - {2:F3}", o.Name, o.Area(), o.Perimeter());
            }

            Console.ReadKey();

        }
    }
}
