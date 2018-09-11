using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Homework10
{
    [Serializable]
    [DataContract]
    public class Student
    {
        public delegate void MyDel(int m);

        [DataMember]
        private string name;
        [DataMember]
        private List<int> marks;

        public Student() { }
        public Student(string name, List<int> marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<int> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public event MyDel MarkChange;

        public void AddMark(int NewMark)
        {
            marks.Add(NewMark);
            MarkChange(NewMark);
        }
    }
}
