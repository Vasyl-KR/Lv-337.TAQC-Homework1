using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2) Утворити похідний від нього клас Цитрус, який має:
- поле - вміст вітаміну С в грамах, 
- конструктор з параметрами, 
- властивість, 
- перевизначені методи Input() та Print().*/

namespace FinalTask
{
    [Serializable]
    public class Citrus : Fruit
    {

        private int vitaminC;

        public Citrus() { }

        public Citrus(string name, string color, int vitaminC) : base(name, color)
        {
            this.vitaminC = vitaminC;
        }

        public int Vitamin_C
        {
            get { return vitaminC; }
            set { vitaminC = value; }
        }

        public override void Input()
        {
            try
            {
                Console.WriteLine("Enter name for citrus");
                Name = Console.ReadLine();

                Console.WriteLine("Enter color");
                Color = Console.ReadLine();

                Console.WriteLine("Enter content of vitamin C (in grams)");
                vitaminC = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
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

        public override void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return "Fruit name - " + Name + ", color - " + Color + ", content of vitamin C - " + vitaminC + "g";
        }
    }
}