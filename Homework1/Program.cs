using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   1) Create abstract class Shape with field name and property Name. 
   Add constructor with 1 parameter  and abstract methods Area() and Perimeter(), 
   which can return area and perimeter of shape; 
   Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).   
   Add necessary constructors, properties to these classes, override methods from abstract class Shape. 
   a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.  
   Write name, area and perimeter of all shapes. 
   b) Find shape with the largest perimeter and print its name. 
   3) Sort shapes by area and print obtained list (Remember about IComparable)
 */

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> figures = new List<Shape>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter data, press 1 to add Circle, press 2 to add Square");
                if (Int32.Parse(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Enter name");
                    string s = Console.ReadLine();
                    Console.WriteLine("Enter radius");
                    figures.Add(new Circle(s, double.Parse(Console.ReadLine())));
                }
                else
                {
                    Console.WriteLine("Enter name");
                    string s = Console.ReadLine();
                    Console.WriteLine("Enter side");
                    figures.Add(new Square(s, double.Parse(Console.ReadLine())));
                }
            }
            foreach (Shape o in figures)
            {
                Console.WriteLine("Name - {0}, Area - {1:F3}, Perimeter - {2:F3}", o.Name, o.Area(), o.Perimeter());
            }
            double max = 0;
            string name = "";
            foreach (Shape o in figures)
            {
                if (o.Perimeter() > max)
                {
                    max = o.Perimeter();
                    name = o.Name;
                }
            }
            Console.WriteLine("Largest perimeter has - {0}, with value - {1:F3}", name, max);

            Console.WriteLine("\nSorted list");
            figures.Sort();
            foreach (Shape o in figures)
            {
                Console.WriteLine("Name - {0}, Area - {1:F3}, Perimeter - {2:F3}", o.Name, o.Area(), o.Perimeter());
            }

            Console.ReadKey();

        }
    }
}
