using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create class Person.
    Class Person should consists of
              a) two private fields: name and birthYear (the birthday year).                 
              (*As a type for this field you may use DataTime type.)
              b) two properties for access to these fields (only get)
              c) default constructor and constructor with 2 parameters 
              d) methods:
                   - Age() - to calculate the age of person
                    -Input() - to input information about person
                    -ChangeName() - to change the name of person
                    -ToString() 
                     -Output() - to output information about person (call ToString())
                    - operator== (equal by name)
     In the method Main() create 6 objects of Person type and input information about them.  
     Then calculate and write to console the name and Age of each person; 
     Change the name of persons, which Age is less then 16, to "Very Young".
     Output information about all persons. 
     Find and output information about Persons with the same names (use ==)
*/

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
