using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18._04._2023
{
    public class DoubleNode
    {
        private int info;
        private DoubleNode next;
        private DoubleNode prev;
        
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public DoubleNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public DoubleNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public DoubleNode() { }
        public DoubleNode(int info) { this.info = info; }
        public DoubleNode(int info, DoubleNode next, DoubleNode prev) { this.Info = info; this.Next = next; this.Prev = prev; }
    }
}
