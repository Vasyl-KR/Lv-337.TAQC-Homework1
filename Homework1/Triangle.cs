using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    public struct Point
    {
        public int x, y;
        public Point(int X, int Y) { x = X; y = Y; }
        public double Distance(Point p1)
        {
            return Math.Sqrt(Math.Pow(p1.x - this.x, 2) + Math.Pow(p1.y - this.y, 2));
        }
        public override string ToString()
        {
            return string.Format("{0},{1}", x, y);
        }
    }
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;
        public Triangle(Point a, Point b, Point c)
        { vertex1 = a; vertex2 = b; vertex3 = c; }

        public double Perimeter()
        {
            return vertex1.Distance(vertex2) + vertex1.Distance(vertex3) + vertex2.Distance(vertex3);
        }
        public double Square()
        {
            return Math.Sqrt(0.5 * this.Perimeter() * (0.5 * this.Perimeter() - vertex1.Distance(vertex2)) * (0.5 * this.Perimeter() - vertex1.Distance(vertex3)) * (0.5 * this.Perimeter() - vertex2.Distance(vertex3)));
        }
        public void Print()
        {
            Console.WriteLine(string.Format("Point 1 - {0}, point 2 - {1}, point 3 - {2}", vertex1.ToString(), vertex2.ToString(), vertex3.ToString()));
        }

    }
}
