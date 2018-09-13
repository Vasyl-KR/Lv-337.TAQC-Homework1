using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

/*3) Утворити List фруктів і додати до нього 5 різних фруктів і цитрусів.
- Видрукувати дані про ті фрукти, колір яких є 'жовтий'.
- Посортувати список фруктів за назвою і результат вивести у файл
- Передбачити перехоплення виняткових ситуацій
- Сериалізувати-десериалізувати список у Xml форматі
- Написати  юніт-тести на методи класів */

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();

            //Створення списку фруктів
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter 'f' for fruit input, anything else for citrus input");
                string check = Console.ReadLine();

                if (check == "f")
                {
                    Fruit fruit = new Fruit();
                    fruit.Input();
                    fruits.Add(fruit);
                }
                else
                {
                    Citrus citrus = new Citrus();
                    citrus.Input();
                    fruits.Add(citrus);
                }
            }

            //Пошук фрукту із жовтим кольором 
            foreach (Fruit fruit in fruits)
            {
                if (fruit.Color.ToLower() == "yellow")
                {
                    fruit.Print();
                }
            }

            fruits.Sort();

            using (StreamWriter sw = new StreamWriter("fruits.txt"))
            {
                foreach (Fruit fruit in fruits)
                {
                    sw.WriteLine(fruit);
                }
            }

            //Серіалізація
            XmlSerializer formatterC = new XmlSerializer(typeof(List<Fruit>));

            using (FileStream fs = new FileStream("fruits.xml", FileMode.OpenOrCreate))
            {
                formatterC.Serialize(fs, fruits);
            }

            //Десеріалізація
            using (FileStream fs = new FileStream("fruits.xml", FileMode.OpenOrCreate))
            {
                List<Fruit> newFruits = formatterC.Deserialize(fs) as List<Fruit>;

                foreach (Fruit fruit in newFruits)
                {
                    Console.WriteLine(fruit);
                }
            }

            Console.ReadKey();
        }
    }
}
