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
Palindrome Checker
