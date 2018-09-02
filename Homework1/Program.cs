using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Визначити клас Car з полями назва, колір, ціна, const полем CompanyName 
  Створити два конструктори – дефолтний і з параметрами.Створити властивість доступу до поля колір. 
  Визначити методи Input() –  для введення даних про машину з консолі, Print() - для виведення даних про машину на консоль                               ChangePrice(double x) – для зміни ціни на х%
  Ввести дані про 3 авто. 
  Зменшити їх ціну на 10%, вивести дані про авто.
  Ввести новий колір і пофарбувати авто з кольором white у вказаний колір
  Перевантажити оператор == для класу Car, авто рівні, якщо назва та ціна рівні 
  Перевизначити в класі Car метод ToString(), який повертає рядок з даними про авто*/

namespace Homework4
{
    class Car
    {
        private string name;
        private string color;
        private double price;
        private const string companyName = "Volkswagen";

        public Car()
        {

        }
        public Car(string n, string c, double p)
        {
            name = n;
            color = c;
            price = p;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter name car:");
            name = Console.ReadLine();
            Console.WriteLine("Enter color car:");
            color = Console.ReadLine();
            Console.WriteLine("Enter cost car:");
            Double.TryParse(Console.ReadLine(), out price);
        }
        public void Print()
        {
            Console.WriteLine("Car name - " + name + ", color - " + color + ", price - {0}", price);
        }
        public void ChangePrice(double x)
        {
            price += price * (x / 100);
        }
        public void ToWhite(string color)
        {
            if (this.color == "white")
            {
                this.color = color;
            }
        }
        public static bool operator ==(Car first, Car second)
        {
            return (first.name == second.name) && (first.price == second.price);
        }
        public static bool operator !=(Car first, Car second)
        {
            return !(first == second);

        }
        public override string ToString()
        {
            return (string.Format("Car name - " + name + ", color - " + color + ", price - {0}", price));
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", "white", 34000);
            Car car2 = new Car("Volvo", "black", 43000);
            Car car3 = new Car("Audi", "green", 34000);
            car2.ChangePrice(-10);
            car2.Print();
            Console.WriteLine("Enter new color");
            car1.ToWhite(Console.ReadLine());
            car1.Print();
            if (car1 == car3)
            {
                Console.WriteLine("The same cars");
            }
            else
            {
                Console.WriteLine("Not the same cars");
            }
            Console.WriteLine(car3.ToString());

            Console.ReadKey();
        }
    }
}
