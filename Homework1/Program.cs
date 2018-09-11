using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create struct Point:
    - fields x and y, 
    - method Distance() to calculate distance between points
    - method ToString(), which return the Point in format "(x,y)"
   Create class Triangle:
    - fields vertex1, vertex2, vertex3 of type Point
    - constructors
    - methods Perimeter(), Square(), Print()
  In the Main() create list of 3 triangles and write into console the information about these shapes.
  *Print the triangle with vertex which is the closest to origin (0,0)
*/

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[9];
            Point origin = new Point(0, 0);
            int j = 0;
            for (int t = 0; t < 3; t++)
            {
                Console.WriteLine("Enter points of {0} triangle", t + 1);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter x and y of {0} point", i + 1);
                    points[i + j] = new Point(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));

                }
                j = j + 3;
            }


            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(points[0], points[1], points[2]));
            triangles.Add(new Triangle(points[3], points[4], points[5]));
            triangles.Add(new Triangle(points[6], points[7], points[8]));
            foreach (Triangle t in triangles)
            {

                Console.WriteLine("Perimeter - {0:F3}, Square - {1:F3}", t.Perimeter(), t.Square());
                t.Print();
            }
            double shortest = Int32.MaxValue;
            int count = 0, minCount = 0;
            j = 0;
            foreach (Triangle t in triangles)
            {
                double[] mins = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    mins[i] = origin.Distance(points[i + j], origin);
                }
                j = j + 3;
                count++;
                if (shortest > mins.Min())
                {
                    shortest = mins.Min();
                    minCount = count;
                }

            }
            Console.WriteLine("Triangle №{0} is the closest to origin", minCount);
            Console.ReadKey();
        }
    }
}
