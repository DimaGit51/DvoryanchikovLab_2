using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Programing
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
        public Node first; // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: инициализация пустого списка
        {
            first = null;
        }

        public int Rec()
        {
            return Recursion(first);
        }

        private int Recursion(Node p)
        {
            if (p == null)
            {
                return 0;
            }
            else
            {
                return 1 + Recursion(p.Link);
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
    }
    public class Program
    {
        static void Main()
        {
            int[] ints = { 0, 1, 2, 3, 4 };
            SingleLinkedList L = new SingleLinkedList();
            L.Create(ints);
            int count = 0;

            count = L.Rec();
            Console.WriteLine("Количество узлов {0}", count);
        }
    }
}