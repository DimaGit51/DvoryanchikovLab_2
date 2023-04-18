using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_18._04._2023
{
    internal class CycleDoubleLinkedList
    {
        private DoubleNode head;
        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }
        public void DeleteNodes(int del)
        {
            if (head != null)
            {

                DoubleNode current = head;
                DoubleNode next = null;
                DoubleNode prev = null;

                while (current.Next != head)
                {
                    if (current.Info == del)
                    {
                        if (current == head)
                            head = current.Next;

                        next = current.Next;
                        prev = current.Prev;

                        next.Prev = prev;
                        prev.Next = next;

                        current = next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        public void CreateOredered(int[] mass)
        {
            if (head != null)
            {
                DoubleNode p, newnode;
                for (int i = 0; i < mass.Length; i++)
                {
                    p = head.Next;
                    newnode = new DoubleNode(mass[i]);
                    DoubleNode p = head.Prev;
                    while (newnode.Info > p.Info && p != head) p = p.Next;
                    newnode.Next = p;
                    newnode.Prev = p.Prev;
                    p.Prev.Next = newnode;
                    p.Prev = newnode;
                }
            }
        }
        public void PrintDoubleList()
        {
            DoubleNode p = head.Next;
            while (p != head)
            {
                Console.WriteLine(p.Info);
                p = p.Next;
            }
        }
    }
}

