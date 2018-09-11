using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Task 1
1. Створити делегат, який отримує і повертає дійсне число.
2. Створити метод Tabulation, який отримує цей делегат та два числа a, b, n  і видруковує значення делегату в точках: a+k*(b-a)/n, k=0,1,2,…n 
3. Викликати метод Tabulation для табуляції функції sin(x), 2x^2+3x*cos(x^3);  

Task 2
Створити делегат void MyDel(int m) 
Створити клас Student, з полями name та marks (типу list<int>), подією MarkChange типу MyDel та методом AddMark (додає нову оцінку до marks, перевіряє чи хтось підписався на подію і викликає її з новою оцінкою)
Створити клас Parent  з методом OnMarkChange (який отримує int оцінку і виводить її на консоль)
В Main Створити студента, батька, підписати батьківський метод OnMarkChange на подію студента MarkChange. Викликати кілька разів метод AddMark для студента 
Створити клас Бухгалтерія, метод ВиплатаСтипендії, який друкує чи буде в студента стипендія чи ні, залежно від свого параметра. Підписати цей метод на подію студента MarkChange

*/

namespace Homework10
{
    class Program
    {
        public delegate double Tab(double n);

        public static double ReturnPoint(double x)
        {
            return x;
        }

        public static double ReturnSin(double x)
        {
            return Math.Sin(x);
        }
        public static double ReturnCos(double x)
        {
            return 2 * x * x + 3 * x * Math.Cos(x * x * x);
        }

        public static void Tabulation(Tab del1, int a, int b, int n)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0:G4}  ", del1(a + k * (b - a) / n));
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 0, b = 5, n = 5;
            Console.WriteLine("Points");
            Tab del1 = ReturnPoint;
            Tabulation(del1, a, b, n);
            Console.WriteLine("sin(x)");
            del1 = ReturnSin;
            Tabulation(del1, a, b, n);
            Console.WriteLine("2x^2+3x*cos(x^3)");
            del1 = ReturnCos;
            Tabulation(del1, a, b, n);
            Console.ReadKey();
        }
    }
}
