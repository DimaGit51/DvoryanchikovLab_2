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
            if (head == null)
                return;

            DoubleNode current = head;
            DoubleNode next = null;
            DoubleNode prev = null;

            while (current != head)
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
}

