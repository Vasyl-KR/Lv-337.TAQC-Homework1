using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    public class Teacher : Staff
    {
        private string subject;
        public Teacher(string name, int salary, string subject) : base(name, salary)
        { this.subject = subject; }
        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and subject {2}", Name, Salary, this.subject);
        }
    }
}
