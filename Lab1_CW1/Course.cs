using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1_CW
{
    internal class Course
    {
        private Group[] groups;
        private string courseid;

        public string Courseid 
        { get { return courseid; } 
          set { courseid = value; } 
        }   
        public Group[] Groups
        {
            get { return groups; }
            set { groups = value; }
        }
        public Course(string number)
        {
            Courseid = number;
            Groups = new Group[2];
        }
        void Print()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                for(int j = 0; j< Groups[i].Students.Length; j++)
                {
                    for(int k=0; k < Groups[i].Students[j].Marks.Length; k++)
                    {
                        if (Groups[i].Students[j].Marks[k]==2)
                        {
                            Console.WriteLine("{0} {1} {2}", Groups[i].Students[j].Name, Groups[i].Subjects[j], Groups[i].Groupid);
                        }
                    }
                }
            }
        }
        static void Main()
        {
            Student st1 = new Student("Ivanov", new byte[] { 2, 3, 4, 5, 2 });
            Student st2 = new Student("Petrov", new byte[] { 5, 3, 4, 5, 3 });
            Student st3 = new Student("Sidorov", new byte[] { 3,3,4,2,5 });
            Student st4 = new Student("Antonov", new byte[] { 3,3,3,3,3 });
            Student st5 = new Student("Borodin", new byte[] { 5,3,4,5,3 });
            Student st6 = new Student("Tarasov", new byte[] { 3,2,4,2,5 });
            Group gr1 = new Group("6101", new string[] { "mar", "fiz", "hist", "progr", "eng" });
            gr1.Students[0] = st1; gr1.Students[1]=st2 ; gr1.Students[2] = st3;
            Group gr2 = new Group("6109", new string[] { "disk_mat", "fiz", "algebra", "progr", "eng" });
            gr2.Students[0] = st4; gr2.Students[1]=st5; gr2.Students[2] = st6;
            Course cr = new Course("Course 1");
            cr.Groups[0] = gr1; cr.Groups[1] = gr2;
            cr.Print();
        }
    }
}
