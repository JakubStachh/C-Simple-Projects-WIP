# Student Management System in C#

## 🧑‍💻 **Overview**

This C# program simulates a **Student Management System**. It allows the user to perform basic CRUD operations on a list of students, including adding, viewing, and updating student details. The system maintains a list of students with their name, age, and course.

---

## 💻 **Program Explanation**

1. **Student Class**:
   - The `Student` class defines the properties `Name`, `Age`, and `Course` for a student.

2. **Main Operations**:
   - **Add**: Adds a new student with details provided by the user.
   - **View**: Displays the list of all students.
   - **Update**: Allows the user to update the details of an existing student.
   - **Exit**: Terminates the program.

3. **Commands**:
   - The program provides a set of commands: `add`, `view`, `update`, and `exit`.

---

## 🧑‍💻 **Code:**

```csharp
using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command;

            Console.WriteLine("Welcome to the Student Management System");
            Console.WriteLine("Commands: add, view, update, exit");

            do
            {
                Console.WriteLine("\nEnter command:");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Enter student name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter student age:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student course:");
                        string course = Console.ReadLine();

                        students.Add(new Student() { Name = name, Age = age, Course = course });
                        Console.WriteLine("Student added successfully.");
                        break;

                    case "view":
                        Console.WriteLine("\nStudent List:");
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students added.");
                        }
                        else
                        {
                            foreach (var student in students)
                            {
                                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Course: {student.Course}");
                            }
                        }
                        break;

                    case "update":
                        Console.WriteLine("Enter student name to update:");
                        string studentName = Console.ReadLine();
                        var studentToUpdate = students.Find(s => s.Name.ToLower() == studentName.ToLower());

                        if (studentToUpdate != null)
                        {
                            Console.WriteLine("Enter new age:");
                            studentToUpdate.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new course:");
                            studentToUpdate.Course = Console.ReadLine();
                            Console.WriteLine("Student updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
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
### Example 1: Add and View Students
```yaml
Welcome to the Student Management System
Commands: add, view, update, exit

Enter command:
add
Enter student name:
John
Enter student age:
20
Enter student course:
Computer Science
Student added successfully.

Enter command:
view

Student List:
Name: John, Age: 20, Course: Computer Science
```

### Example 2: Update and View Students
```yaml
Enter command:
update
Enter student name to update:
John
Enter new age:
21
Enter new course:
Software Engineering
Student updated successfully.

Enter command:
view

Student List:
Name: John, Age: 21, Course: Software Engineering
```

---
## 🔍 Explanation:
- **Add**: The program allows you to add a student by providing their name, age, and course.

- **View**: After adding students, you can view the list of all students along with their details.

- **Update**: You can update the information of an existing student by providing their name and new details (age and course).

- **Exit**: Exits the program when the user types "exit".
