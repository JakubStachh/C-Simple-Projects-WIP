# Simple To-Do List Application in C#

## 📝 **Overview**

This C# console application allows users to manage their to-do list. Users can:
1. Add tasks.
2. View the current list of tasks.
3. Exit the application.

The application uses a simple list to store the tasks and provides a command-line interface for interacting with the to-do list.

---

## 💻 **Program Explanation**

### **Main Features**:
- **Add Task**: Adds a task to the to-do list.
- **View Tasks**: Displays the list of all tasks.
- **Exit**: Exits the application.

### **Steps**:
1. **Add Task**: The user can enter a description of the task, which is added to the list of tasks.
2. **View Tasks**: The user can view all tasks added so far. If no tasks are present, it informs the user that there are no tasks.
3. **Exit**: Terminates the program when the user enters the command `exit`.

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 How It Works:
### 1. Add Task:
- When the user enters the command `add`, the program prompts for a task description. The entered task is added to the list (`todoList`).

### 2. View Tasks:
- If the user enters `view`, the program prints all tasks currently in the list. If the list is empty, it informs the user that no tasks have been added yet.

### 3. Exit:
- The program runs in a loop until the user types `exit`, at which point the program will terminate with a message saying "Exiting program."

---
## 🖼️ Sample Output:
### Example 1 - Add Task and View Tasks:
```yaml
Simple To-Do List Application
Enter 'add' to add a task, 'view' to view tasks, 'exit' to quit.

Enter command:
add
Enter task description:
Buy groceries
Task added.

Enter command:
add
Enter task description:
Call the doctor
Task added.

Enter command:
view

Your To-Do List:
1. Buy groceries
2. Call the doctor
```

### Example 2 - View Empty List:
```yaml
Enter command:
view

Your To-Do List:
No tasks added.
```

### Example 3 - Exit Program:
```yaml
Enter command:
exit
Exiting program.
```
