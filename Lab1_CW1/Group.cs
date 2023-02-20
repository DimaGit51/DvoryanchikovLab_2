using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_CW
{
    internal class Group
    {
        private string groupid;
        private string[] subjects;
        private Student[] students;

        public string Groupid
        {
            get { return groupid; }
            set { groupid = value; }
        }
        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }
        public string[] Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
        public Group(string groupid, string[] subjects)
        {
            Groupid = groupid;
            Subjects = subjects;
            Students = new Student[3];
        }
    }
}
