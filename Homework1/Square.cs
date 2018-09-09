﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(string name, double side)
            : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}
