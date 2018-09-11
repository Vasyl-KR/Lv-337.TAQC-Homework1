using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();
            Student stud = new Student("Ivan", marks);
            Parent par = new Parent();
            AccountingDepartment dep = new AccountingDepartment();
            stud.MarkChange += par.OnMarkChange;
            stud.MarkChange += dep.ScholarshipPayment;
            stud.AddMark(4);
            stud.AddMark(3);
            stud.AddMark(2);
            stud.AddMark(5);

            Console.ReadKey();
        }
    }
}
