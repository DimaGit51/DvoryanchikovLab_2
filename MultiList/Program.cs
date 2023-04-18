using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MultiList
{
    internal class Program
    {
        static void Main()
        {
            MultiLinkedList M = new MultiLinkedList();
            M.CreareMulti(new string[] { "Андреев", "Борисов", "Яковлев" }, new double[] { 4, 5, 6, 0, 4, 2 });
            M.PrintMark();
        }
        public class MultiNode // Класс «Узел мультисписка»
        {
            private string fam; // фамилия_имя_отчество
            private double mark; // средний балл
            private MultiNode fnext; // поля связи в списке по фамилии
            private MultiNode fprev;
            private MultiNode mnext; // поля связи в списке по среднему баллу
            private MultiNode mprev;
            public string Fam
            {
                get { return fam; }
                set { fam = value; }
            } // свойства
            public double Mark
            {
                get { return mark; }
                set { mark = value; }
            }
            public MultiNode Fnext
            {
                get { return fnext; }
                set { fnext = value; }
            }
            public MultiNode Fprev
            {
                get { return fprev; }
                set { fprev = value; }
            }
            public MultiNode Mnext
            {
                get { return mnext; }
                set { mnext = value; }
            }
            public MultiNode Mprev
            {
                get { return mprev; }
                set { mprev = value; }
            }
            public MultiNode() { } // конструкторы
            public MultiNode(string fam, double mark)
            { Fam = fam; Mark = mark; }
        }
        public class MultiLinkedList // Класс “Мультисписок”
        {
            private MultiNode head;

            public MultiLinkedList() // создание элементарного мультисписка
            {
                head = new MultiNode();
                head.Fnext = head;
                head.Fprev = head;
                head.Mnext = head;
                head.Mprev = head;
            }
            public void PrintFam() // распечатка мультисписка,
            { // упорядоченного по алфавиту
                 if (head != null ) // список существует?
                 {
                     MultiNode p = head.Fnext; // установить вспомогательную ссылку
                     while (p != head ) // весь список пройден?
                     { // распечатать информационные поля}
                        Console.WriteLine("{0} {1}",p.Fam, p.Mark);
                        p=p.Fnext; // перейти к следующему узлу
                     }
                  }
            }
            public void PrintMark() // распечатка мультисписка,}
            { // упорядоченного по среднему баллу
                if (head != null) // список существует?
                {
                    MultiNode p = head.Mnext; // установить вспомогательную ссылку
                    while (p != head) // весь список пройден?
                    { // распечатать информационные поля
                        Console.WriteLine("{0} {1}",p.Fam, p.Mark);
                        p = p.Mnext; // перейти к следующему узлу
                    }
                }
            }
            public void CreareMulti(string[] fams, double[] marks)
            {
                if (head != null)
                {
                    MultiNode p, newnode;
                    for(int i=0; i<fams.Length; i++)
                    {
                        newnode = new MultiNode(fams[i], marks[i]);
                        p = head.Fnext;
                        while ((p != head) && (String.Compare(newnode.Fam, p.Fam, true) > 0)) p = p.Fnext;
                        newnode.Fnext = p;
                        newnode.Fprev = p.Fprev;
                        p.Fprev.Fnext = newnode;
                        p.Fprev = newnode;
                        p = head.Mnext;
                        while((p!=head)&&(newnode.Mark<p.Mark)) p=p.Mnext;
                        newnode.Mnext = p; newnode.Mprev = p.Mprev;
                        p.Mprev.Mnext = newnode; p.Mprev = newnode;
                    }
                }
            }
        }
    }
}
