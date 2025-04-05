# Linked List Implementation in C#

## 🧑‍💻 **Overview**

This C# program demonstrates how to implement a simple **singly linked list** with basic operations such as:
- **InsertAtEnd**: Adds a node with the specified data to the end of the list.
- **Delete**: Removes a node with the specified data from the list.
- **Display**: Displays the elements of the list.

The linked list is implemented using a `Node` class to represent each element and a `LinkedList` class to manage the list's operations.

---

## 💻 **Program Explanation**

1. **Node Class**:
   - Represents an individual element of the linked list.
   - Contains two members:
     - `Data`: Stores the value of the node.
     - `Next`: A reference to the next node in the list.

2. **LinkedList Class**:
   - Manages the linked list and contains the following methods:
     - `InsertAtEnd(int data)`: Adds a new node with the specified data at the end of the list.
     - `Delete(int data)`: Removes the first node with the given data.
     - `Display()`: Prints all the elements in the linked list.

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 Example Run:
### Input/Output Example:
```
10 20 30 
10 30
```

---
## 🔍 Explanation:
### `InsertAtEnd`:

- Adds a node at the end of the list. If the list is empty (i.e., `head` is `null`), the new node becomes the first node. Otherwise, it traverses to the last node and inserts the new node after it.

### `Delete`:

- If the node to delete is the first node (`head`), it updates `head` to the next node. If the node is somewhere else, it traverses the list and updates the `Next` pointer of the previous node to skip over the node to be deleted.

### `Display`:

- Traverses the linked list from the `head` to the end and prints the data of each node.
