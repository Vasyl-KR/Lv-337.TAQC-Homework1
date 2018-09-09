using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Peoples = new List<Person>();
            Peoples.Add(new Person("Oleg"));
            Peoples.Add(new Staff("Igor", 200));
            Peoples.Add(new Teacher("Vasyl", 100, "History"));
            Peoples.Add(new Developer("Ivan", 1000, "Junior"));

            foreach (Person o in Peoples)
            {
                o.Print();
            }

            Console.WriteLine("Enter name of person");
            string name = Console.ReadLine();
            bool check = false;
            foreach (Person o in Peoples)
            {
                if (o.Name == name)
                {
                    o.Print();
                    check = true;
                    break;
                }
            }
            if (check == false)
                Console.WriteLine("Such person not found");

            Console.ReadKey();

        }
    }
}
