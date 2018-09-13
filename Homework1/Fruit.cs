using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

/*1) Утворити клас Фрукт, який містить:
- поля назва та колір, 
- визначити конструктор з параметрами, 
- віртуальні методи Input() та Print(), для зчитування даних з консолі та виведення даних на консоль, 
а також перевантажити варіанти введення-виведення з файлу.
- властивості для полів, 
- перевизначити метод ToString(). */

namespace FinalTask
{
    [Serializable]
    [XmlInclude(typeof(Citrus))]
    [XmlType("fruits")]
    public class Fruit : IComparable<Fruit>
    {

        private string name;

        private string color;

        public Fruit() { }

        public Fruit(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Ведення даних
        public virtual void Input()
        {
            try
            {
                Console.WriteLine("Enter name for fruit");
                Name = Console.ReadLine();

                Console.WriteLine("Enter color");
                Color = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid string");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value cannot be null");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //public virtual void Input(string path)
        //{
        //    using (StreamReader sr = new StreamReader("InpudData.txt")
        //    {

        //    }
        //}

        //Виведення даних
        public virtual void Print()
        {
            Console.WriteLine(this);
            //Console.WriteLine($"Fruit name - {name}, color - {color}");
        }

        public override string ToString()
        {
            return "Fruit name - " + name + ", color - " + color;
        }

        public int CompareTo(Fruit other)
        {
            return name.CompareTo(other.name);
        }
    }
}

