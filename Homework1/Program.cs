using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Визначити перелічення TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted). 
  Змінній test1Status присвоїти значення Pass і вивести значення змінної на консоль.

  Визначити структуру RGB, яка представляє колір з полями red, green, blue типу byte . Визначити дві змінні цього типу і ввести їх поля для білого та 
  чорного кольорів.
*/

namespace Homework2
{
    enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };

    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //task1
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            //task2
            RGB white, black;
            white.red = 255;
            white.green = 255;
            white.blue = 255;
            black.red = 0;
            black.green = 0;
            black.blue = 0;

            Console.ReadKey();

        }
    }
}
