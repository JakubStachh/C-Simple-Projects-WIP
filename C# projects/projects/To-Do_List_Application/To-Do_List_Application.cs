using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            string command;

            Console.WriteLine("Simple To-Do List Application");
            Console.WriteLine("Enter 'add' to add a task, 'view' to view tasks, 'exit' to quit.");

            do
            {
                Console.WriteLine("\nEnter command:");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter task description:");
                        string task = Console.ReadLine();
                        todoList.Add(task);
                        Console.WriteLine("Task added.");
                        break;

                    case "view":
                        Console.WriteLine("\nYour To-Do List:");
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("No tasks added.");
                        }
                        else
                        {
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
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
