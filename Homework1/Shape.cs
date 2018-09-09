using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
        public abstract int CompareTo(Shape other);
    }
}

