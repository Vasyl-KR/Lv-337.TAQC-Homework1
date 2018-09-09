using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Developer : Staff
    {
        private string level;
        public Developer(string name, int salary, string level) : base(name, salary)
        { this.level = level; }
        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and level {2}", Name, Salary, this.level);
        }
    }
}
