using System;

namespace LinkedListExample
{
    class Node
    {
        public int Data;
        public Node Next;
        
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        private Node head;

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public void Delete(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data != data)
            {
                temp = temp.Next;
            }

            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertAtEnd(10);
            list.InsertAtEnd(20);
            list.InsertAtEnd(30);
            list.Display();  // Output: 10 20 30 

            list.Delete(20);
            list.Display();  // Output: 10 30
        }
    }
}
