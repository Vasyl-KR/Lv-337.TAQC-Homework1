using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            
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
