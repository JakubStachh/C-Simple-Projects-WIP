# LINQ Example in C#

## 🧑‍💻 **Overview**

This C# program demonstrates the use of LINQ (Language Integrated Query) to filter and sort a collection of student objects based on certain criteria. In this example, the program:
- Filters students whose age is 19 or older.
- Sorts them by their names in alphabetical order.
- Displays the result on the console.

---

## 💻 **Program Explanation**

1. **Student Class**:
   - Contains two properties: `Name` and `Age` to store the details of each student.

2. **LINQ Operations**:
   - `Where(s => s.Age >= 19)`: Filters students who are 19 years old or older.
   - `OrderBy(s => s.Name)`: Sorts the filtered students by their name in ascending order.
   - `ToList()`: Converts the filtered and sorted result into a list.

3. **Display**:
   - The `foreach` loop is used to display the names and ages of the filtered and sorted students.

---

## 🧑‍💻 **Code:**

```csharp
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
```

---
## 🚀 Example Run:
### Input/Output Example:
```
Mary, 19
Paul, 20
Sarah, 22
```

---
## 🔍 Explanation:
### LINQ `Where` Method:

- Filters the `students` list to include only those with `Age >= 19`.

 ### LINQ `OrderBy` Method:

- Sorts the filtered students alphabetically by their `Name`.

### `foreach` Loop:

- Iterates through the sorted list and prints each student's name and age.
