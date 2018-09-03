using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Develop interface IFlyable with method Fly().
Create two classes Bird (with fields: name and canFly) and Plane  (with fields: mark and highFly),
which implement interface IFlyable.
Create List of IFlyable objects and add some Birds and Planes to it. 
Call Fly() method for every item from the list of it*/

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyes = new List<IFlyable>(3);
            flyes.Add(new Bird("Owl", true));
            flyes.Add(new Plane("Boing", 11000));
            foreach (IFlyable f in flyes)
            {
                f.Fly();
            }

            Console.ReadKey();

        }
    }
}
