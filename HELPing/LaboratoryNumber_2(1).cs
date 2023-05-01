using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELPing
{
    public class Node
    {
        private int info;
        private Node link;
        // Класс «Узел односвязного списка»
        // информационное поле узла
        // поле связи узла
        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        // свойства
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }

        public Node(int info) // конструкторы
        {
            Info = info;
        }
        public Node(int info, Node link)
        {
            Info = info; Link = link;
        }
    }
    public class SingleLinkedList // Класс «Односвязные списки»
    {
        private Node first; // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: инициализация пустого списка
        {
            first = null;
        }
        public static void MergeLists(SingleLinkedList list1, SingleLinkedList list2)
        {
            SingleLinkedList mergedList = new SingleLinkedList();
            Node current1 = list1.first;
            Node current2 = list2.first;

            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    mergedList.InsertAfterEnd(current1.Info);
                    current1 = current1.Link;
                }

                if (current2 != null)
                {
                    mergedList.InsertAfterEnd(current2.Info);
                    current2 = current2.Link;
                }
            }
            mergedList.Print();
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            { // first – ссылка на первый узел списка
              // data – значение информационного поля
              // узла списка
              // создание узла списка
              // заполнение инф. поля узла списка - data
                p.Link = first; // установка связи между вставленным узлом и списком
                first = p; // новое значение ссылки на первый узел
            }
        }
        public void InsertAfterEnd(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                }
                q.Link = p;
            }
        }
        public void InsertRandom(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                Node q = first;
                int count = 0;
                while (q.Link != null)
                {
                    q = q.Link;
                    count++;
                }
                Random rnd = new Random();
                int countRnd = rnd.Next(1, count);



                Node nc = null;
                Node qc = first;
                count = 0;
                while (qc != null && count < countRnd)
                {
                    nc = qc;
                    qc = qc.Link;
                    count++;
                }
                nc.Link = p;
                p.Link = qc;
            }
        }
        public void DeleteBeforeFirst()
        {
            if (first != null) first = first.Link;
        }
        public void DeleteAfterEnd()
        {
            if (first != null)
            {

                int count = 0;
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                    count++;
                }
                int countS = 0;
                Node p = first;
                while (p.Link != null && countS < count - 1)
                {
                    p = p.Link;
                    countS++;
                }
                DeleteRightElement(p);
            }
        }
        public void DeleteRandom()
        {
            if (first != null)
            {
                int count = 0;
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                    count++;
                }
                Random rnd = new Random();
                int countRnd = rnd.Next(1, count);
                int countS = 0;
                Node p = first;
                while (p.Link != null && countS < countRnd)
                {
                    p = p.Link;
                    countS++;
                }
                DeleteRightElement(p);
            }
        }
        public void DeleteRightElement(Node p)
        { // p – предварительно установленная ссылка
            if (first != null)
            {
                Node q; // q – ссылка на исключаемый узел
                if (p != null && p.Link != null) // сылка p действительно установлена?

                // ссылка p не указывает на последний узел в списке?
                {
                    q = p.Link; // установить ссылку q на узел, следующий за элементом p
                    p.Link = q.Link; // изменить поле связи узла, за которым выполняется исключение
                }
            }
        }
        public void Create(int[] mass)
        {
            first = null;
            for (int i = 0; i < mass.Length; i++)
            {
                Node p = new Node();
                p.Info = mass[i];
                p.Link = first;
                first = p;
            }
        }
        public void Destroy()
        {
            first = null;
        }
        public void Print()
        {
            Node p = first;
            while (p != null)
            {
                Console.WriteLine(p.Info);
                p = p.Link;
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            int[] ints = { 0, 1, 2, 3, 4 };
            SingleLinkedList L = new SingleLinkedList();
            L.Create(ints);
            Console.WriteLine("Добавление в начало списка элемента 55");
            L.InsertBeforeFirst(55);
            L.Print();
            Console.WriteLine("Добавление в конец списка элемента 10");
            L.InsertAfterEnd(10);
            L.Print();
            Console.WriteLine("Добавление в random списка элемента 7");
            L.InsertRandom(7);
            L.Print();
            Console.WriteLine("Удаление Элемента в начале списка");
            L.DeleteBeforeFirst();
            L.Print();
            Console.WriteLine("Удаление Элемента в конце списка");
            L.DeleteAfterEnd();
            L.Print();
            Console.WriteLine("Удаление Элемента в random списка");
            L.DeleteRandom();
            L.Print();
            Console.WriteLine("Разрушение списка");
            L.Destroy();
            L.Print();

            int[] ints1 = { 1, 3, 5, 7, 9 };
            int[] ints2 = { 2, 4, 6, 8, 10 };

            SingleLinkedList l1 = new SingleLinkedList();
            SingleLinkedList l2 = new SingleLinkedList();

            l1.Create(ints1);
            l2.Create(ints2);

            SingleLinkedList.MergeLists(l2, l1);
        }
    }

}
