using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecursionList
{
    internal class Program
    {
        static void Main()
        {
            RecursiveList L = new RecursiveList();
            L.First = L.CreateRecursive(3);
            L.Print

        }
        public class RecursiveList
        {
            private Node first; // ссылка на первый узел списка
            public Node First // свойства для доступа к ссылке на первый узел списка
            {
                get { return first; }
                set { first = value; }
            }
            public RecursiveList() // конструктор
            {
                first = null;
            }
        }
        public class Node
        {
            private int info;
            private Node link;
            public int Info
            {
                get { return info; }
                set { info = value; }
            }
            public Node Link
            {
                get { return link; }
                set { link = value; }
            }
            public Node() { }
            public Node(int info)
            {
                Info = info;
            }
            public Node(int info, Node link)
            {
                Info = info; Link = link;
            }
        }
        public void PrintBack(Node first) // распечатка содержимого списка
        {
            // в прямом направлении; first – не поле класса, а формальный параметр функции –
            // ссылка на первый узел списка, этот параметр можно назвать как угодно
            if (first != null)
            {
                PrintBack(first.Link); // хвостовая рекурсия
                Console.WriteLine(first.Info);
            }
        }
        public Node CreateRecursive(int n)
        {
            int x; Node first;
            if (n == 0) first = null;
            else {

                Console.Write("Введите количество элементов = ");
                int x;
                while ((!int.TryParse(Console.ReadLine(), out x)))
                {
                    Console.Write("Вы ввели не число ^int^! Введите число: ");
                }
                first = new Node(x);
                first.Link = CreateRecursive(n - 1);
            }
            return first;
        }
    }
}