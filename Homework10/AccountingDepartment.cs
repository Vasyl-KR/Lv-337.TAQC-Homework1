using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class AccountingDepartment
    {
        public void ScholarshipPayment(int marks)
        {
            if (marks >= 4)
            {
                Console.WriteLine("The scholarship will be");
            }
            else
            {
                Console.WriteLine("There will be no scholarship");
            }
        }
    }
}
