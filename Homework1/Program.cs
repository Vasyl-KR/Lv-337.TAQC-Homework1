using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1) Додайте два класи Person та Staff (використайте код з презентації)
2) Утворіть два класи Teacher та  Developer, похідні від Staff. Для класу Teaсher додайте поле subject, 
а для класу Developer – поле level, перевизначте метод Print для обох класів.
3)В Main  визначте список типу Person та додайте до нього об’єкти кожного типу.
Викличте для кожного елементу списку метод Print()
4) Введіть ім’я персони і знайдіть чи є така персона у вашому списку, якщо так – видрукуйте про неї інформацію
*/

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
