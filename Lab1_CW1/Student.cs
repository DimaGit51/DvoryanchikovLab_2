using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CW
{
    internal class Student
    {
        private string name;
        private byte[] marks;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public Student(string name, byte[] marks)
        {
            Name = name;
            Marks = marks;
        }
    }
}
