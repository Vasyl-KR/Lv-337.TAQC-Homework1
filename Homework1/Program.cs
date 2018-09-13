using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
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
            //fruits = FruitsCreateConsole(5);
            fruits = FruitsCreateFromFile();

            YellowSearch(fruits);
            fruits.Sort();

  
            using (StreamWriter sw = new StreamWriter(@"..\..\Fruits.txt"))
            {
                foreach (Fruit fruit in fruits)
                {
                    sw.WriteLine(fruit);
                }
            }

            //try
            //{
                //Xml serilization
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<Fruit>));

                using (FileStream fs = new FileStream(@"..\..\fruits.xml", FileMode.OpenOrCreate))
                {
                    xmlFormatter.Serialize(fs, fruits);
                }

            Console.WriteLine("Deserilisation");
            //Xml deserilization
            using (FileStream fs = new FileStream(@"..\..\fruits.xml", FileMode.OpenOrCreate))
                {
                    List<Fruit> newFruits = xmlFormatter.Deserialize(fs) as List<Fruit>;

                    foreach (Fruit fruit in newFruits)
                    {
                        Console.WriteLine(fruit);
                    }
                }
            //}
            //catch(InvalidOperationException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            Console.ReadKey();
        }


        public static List<Fruit> FruitsCreateConsole (int amount)
        {
            List<Fruit> fruits = new List<Fruit>();
            for (int i = 0; i < amount; i++)
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
            return fruits;
        }

        public static List<Fruit> FruitsCreateFromFile()
        {
            List<Fruit> fruits = new List<Fruit>();
            using (StreamReader sr = new StreamReader(@"..\..\InputData.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Any(c => char.IsDigit(c)))
                    {
                        Citrus tempFruit = new Citrus();
                        tempFruit.Input(line);
                        fruits.Add(tempFruit);
                    }
                    else
                    {
                        Fruit tempFruit = new Fruit();
                        tempFruit.Input(line);
                        fruits.Add(tempFruit);
                    }
                }
            }
            return fruits;
        }

        public static void YellowSearch(List<Fruit> fruits)
        {
            foreach (Fruit fruit in fruits)
            {
                if (fruit.Color.ToLower() == "yellow")
                {
                    fruit.Print();
                }
            }
        }
    }
}
