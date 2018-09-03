using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Builder : IDeveloper
    {
        private string tool;
        public string Tool { get { return tool; } set { tool = value; } }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Tool created");
        }

        public void Destroy()
        {
            Console.WriteLine("Tool destroyed");
        }
    }
}
