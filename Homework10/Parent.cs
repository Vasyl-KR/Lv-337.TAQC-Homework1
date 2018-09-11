using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Parent
    {
        public void OnMarkChange(int NewMark)
        {
            Console.WriteLine("Your student received a new mark - {0}", NewMark);
        }
    }
}
