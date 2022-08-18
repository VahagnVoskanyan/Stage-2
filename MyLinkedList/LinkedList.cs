using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    internal class LinkedList
    {
        public int Count { get; set; }
        LinkedListNode head;
        public LinkedList()
        {
            head = null;
        }
        public void AddNodeFirst(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            Count++;
        }
        public void AddNodeLast(int data)//kam petqa verji elementi vrae misht cucichy pahel!!
        {
            LinkedListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            LinkedListNode node = new LinkedListNode(data);
            current.next = node;
            Count++;
        }
        public void PrintList()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
