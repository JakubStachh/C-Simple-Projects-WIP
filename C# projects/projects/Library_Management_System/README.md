# Library Management System Program in C#

## 🧑‍💻 **Overview**

This is a simple console-based library management system that allows users to **add**, **remove**, and **view** books in a library. It uses a `List<Book>` to store book information. Each book contains a title and author.

---

## 💻 **Program Explanation**

1. **Book Class**: 
   - Contains two properties: `Title` and `Author` for storing the information about each book.

2. **Main Program Logic**:
   - The program continuously asks the user for commands:
     - **add**: Adds a new book to the library.
     - **remove**: Removes a book based on its title.
     - **view**: Displays all the books currently in the library.
     - **exit**: Exits the program.

   The commands are handled inside a `do-while` loop, ensuring that the program continues running until the user chooses to exit.

---

## 🧑‍💻 **Code:**

```csharp
using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();
            string command;

            Console.WriteLine("Welcome to the Library Management System");
            Console.WriteLine("Commands: add, remove, view, exit");

            do
            {
                Console.WriteLine("\nEnter command:");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter book title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter book author:");
                        string author = Console.ReadLine();

                        library.Add(new Book() { Title = title, Author = author });
                        Console.WriteLine("Book added to the library.");
                        break;

                    case "remove":
                        Console.WriteLine("Enter book title to remove:");
                        string bookTitle = Console.ReadLine();
                        var bookToRemove = library.Find(b => b.Title.ToLower() == bookTitle.ToLower());

                        if (bookToRemove != null)
                        {
                            library.Remove(bookToRemove);
                            Console.WriteLine("Book removed.");
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case "view":
                        Console.WriteLine("\nBooks in Library:");
                        if (library.Count == 0)
                        {
                            Console.WriteLine("No books in library.");
                        }
                        else
                        {
                            foreach (var book in library)
                            {
                                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
                            }
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            } while (command != "exit");
        }
    }
}
```

---
## 🚀 Example Run:
### Input/Output Example:
```
Welcome to the Library Management System
Commands: add, remove, view, exit

Enter command:
add
Enter book title:
The Great Gatsby
Enter book author:
F. Scott Fitzgerald
Book added to the library.

Enter command:
view

Books in Library:
Title: The Great Gatsby, Author: F. Scott Fitzgerald

Enter command:
remove
Enter book title to remove:
The Great Gatsby
Book removed.

Enter command:
view

Books in Library:
No books in library.

Enter command:
exit
Exiting program.
```

---
## 🔍 Explanation:
The program allows the user to add, view, and remove books from a library. The add command stores the book title and author, the remove command removes the book based on the title, and the view command displays all the books in the library.
