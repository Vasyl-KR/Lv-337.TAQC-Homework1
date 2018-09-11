using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;


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

            BinaryFormatter bSer = new BinaryFormatter();
            using (FileStream fs = new FileStream("Binary.txt", FileMode.Create))
            {
                bSer.Serialize(fs, stud);
            }
            XmlSerializer xmlSer = new XmlSerializer(typeof(Student));
            using (FileStream fs = new FileStream("XML.txt", FileMode.Create))
            {
                xmlSer.Serialize(fs, stud);
            }
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
            using (FileStream fs = new FileStream("Json.json", FileMode.Create))
            {
                jsonSer.WriteObject(fs, stud);
            }

            Console.ReadKey();
        }
    }
}
