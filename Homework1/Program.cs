using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Person
    {
        private string name;
        private DateTime birthYear;

        public Person()
        {
        }
        public Person(string n, DateTime d)
        {
            name = n;
            birthYear = d;
        }
        public string Name
        {
            get { return name; }
        }
        public DateTime Year
        {
            get { return birthYear; }
        }
        public override string ToString()
        {
            return "Person name - " + name + ", Year - " + birthYear.Year;
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public int Age()
        {
            return (DateTime.Today).Year - birthYear.Year;
        }
        public void Input()
        {
            Console.WriteLine("Enter name of person:");
            name = Console.ReadLine();
            Console.WriteLine("Enter year of birth");
            birthYear = new DateTime(Int32.Parse(Console.ReadLine()), 1, 1);
        }
        public void ChangeName(string name)
        {
            this.name = name;
        }
        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Person[] Peoples = new Person[6];
            for (int i = 0; i < 6; i++)
            {
                Person person = new Person();
                person.Input();
                Peoples[i] = person;
            }
            Console.WriteLine();
            foreach (Person person in Peoples)
            {
                Console.WriteLine("Name - {0}, Age - {1}", person.Name, person.Age());
            }
            foreach (Person person in Peoples)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }
            Console.WriteLine();
            foreach (Person person in Peoples)
            {
                person.Output();
            }
            Console.WriteLine("");
            for (int i = 0; i < 6; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (Peoples[i] == Peoples[j])
                    {
                        Console.WriteLine("Person {0} and Person {1} has the same name", i + 1, j + 1);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
