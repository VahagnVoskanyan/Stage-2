namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeFirst(1);
            linkedList.AddNodeFirst(2);
            linkedList.AddNodeFirst(3);
            linkedList.AddNodeLast(4);
            linkedList.AddNodeLast(5);
            linkedList.AddNodeLast(6);
            linkedList.PrintList();
        }
    }
}