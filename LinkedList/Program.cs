using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();

            var integerList = new int[6] { 5, 10, 20, 2, 4, 9 };

            foreach (var i in integerList)
            {
                linkedList.InsertLast(i);
            }

            var firstNode = linkedList.GetFirstNode();
            Console.WriteLine("FirstNode: " + firstNode.data);

            var lastNode = linkedList.GetLastNode();
            Console.WriteLine("LastNode: " + lastNode.data);

            Console.WriteLine("All Nodes");
            linkedList.PrintLinkedList(linkedList.head);

            linkedList.DeleteFirstNode();
            Console.WriteLine("\nRemove First Node");
            linkedList.PrintLinkedList(linkedList.head);

            linkedList.DeleteLastNode();
            Console.WriteLine("\nRemove Last Node");
            linkedList.PrintLinkedList(linkedList.head);

            linkedList.ReverseLinkedList();
            Console.WriteLine("\nReverse Last Node");
            linkedList.PrintLinkedList(linkedList.head);
        }
    }
}
