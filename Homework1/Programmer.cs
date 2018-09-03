using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Programmer : IDeveloper
    {
        private string language;
        public string Tool { get { return language; } set { language = value; } }

        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            Console.WriteLine("Language created");
        }

        public void Destroy()
        {
            Console.WriteLine("Language destroyed");
        }
    }
}
