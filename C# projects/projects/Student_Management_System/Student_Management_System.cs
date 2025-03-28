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
