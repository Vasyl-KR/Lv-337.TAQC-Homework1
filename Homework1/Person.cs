using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Person
    {
        private string name;
        public Person(string name)
        { this.name = name; }
        public string Name { get { return name; } }
        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
}
