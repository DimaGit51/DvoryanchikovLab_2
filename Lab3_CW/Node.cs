using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_CW
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

        public class SingleLinkedList // Класс «Односвязные списки»
        {
            private Node first; // ссылка на первый узел списка
            public SingleLinkedList() // конструктор: инициализация пустого списка
            {
                first = null;
            }
            public void InsertBeforeFirst(int data)
            {
                Node p = new Node();
                p.Info = data;
                // first – ссылка на первый узел списка
                // data – значение информационного поля
                // узла списка
                // создание узла списка
                // заполнение инф. поля узла списка - data
                p.Link = first; // установка связи между вставленным узлом и списком
                first = p; // новое значение ссылки на первый узел
            }
            public void InsertBeforeFirst1(int data)
            {
                Node p1 = new Node(data, first);
            }

            public void Create(int[] mass)
            {
                first = null;
                for (int i = 0; i < mass.Length;)
                {
                    Node p = new Node();
                    p.Info = mass[i];
                    p.Link = first;
                    first = p;
                }
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


            // значение информационного поля первого элемента
            // значение поля связи первого элемента – адрес второго
            //элемента

            // … // методы обработки списка
        }

        static void Main()
        {
            int[] ints = {0,1,2,3,4}; 
            SingleLinkedList L = new SingleLinkedList();
            L.InsertBeforeFirst(10);
            L.Create(ints);
            L.Print();


        }

    }
}
