using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Plane : IFlyable
    {
        private string name;
        private int highFly;

        public Plane(string name, int highFly)
        {
            this.name = name;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine("{0}m", highFly);
        }
    }
}
