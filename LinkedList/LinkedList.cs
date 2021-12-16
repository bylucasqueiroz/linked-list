using System;
namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;

        public LinkedList()
        {
            head = null;
        }

        internal void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        internal void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal Node GetFirstNode()
        {
           return head;
        }

        internal void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        internal void DeleteFirstNode()
        {
            head = head.next;
        }

        internal void DeleteLastNode()
        {
            if (head != null)
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;

                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }

                    temp.next = null;
                }
            }
        }

        internal void DeleteNodebyKey(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void ReverseLinkedList()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        internal void PrintLinkedList(Node node)
        {
            Console.Write("| " + node.data + " |");

            if (node.next == null)
            {
                return;
            }

            PrintLinkedList(node.next);
        }
    }
}
