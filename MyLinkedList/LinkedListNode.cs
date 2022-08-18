using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    internal class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
