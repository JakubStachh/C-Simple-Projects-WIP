using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExample
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "John", Age = 18 },
                new Student { Name = "Sarah", Age = 22 },
                new Student { Name = "Paul", Age = 20 },
                new Student { Name = "Mary", Age = 19 }
            };

            var sortedStudents = students
                .Where(s => s.Age >= 19)
                .OrderBy(s => s.Name)
                .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }
        }
    }
}
