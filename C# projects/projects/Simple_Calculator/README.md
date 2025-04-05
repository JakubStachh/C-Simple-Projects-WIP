# Simple Calculator - C# Program

## 🧑‍💻 **Overview**

This C# program functions as a simple calculator. It takes two numbers and an operation from the user, and performs the corresponding arithmetic operation. The supported operations are addition, subtraction, multiplication, and division. If division is selected and the second number is zero, it handles the division by zero error gracefully.

---

## 💻 **Program Explanation**

1. **Input**:
   - The program first prompts the user to enter two numbers (`num1` and `num2`).
   - Then, it asks the user to specify the desired arithmetic operation (`+`, `-`, `*`, `/`).

2. **Operations**:
   - Using a `switch` statement, the program checks which operation the user chose and performs the corresponding arithmetic calculation.
   - If the user chooses an invalid operation, the program outputs an error message.

3. **Edge Handling**:
   - The program handles the division by zero scenario, outputting an error message if the second number is zero during division.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Error: Division by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
```

---
## 🚀 Example Run:
### Input/Output Example 1:
```
Enter the first number:
12
Enter the second number:
4
Enter operation (+, -, *, /):
+
Result: 16
```

### Input/Output Example 2:
```
Enter the first number:
10
Enter the second number:
5
Enter operation (+, -, *, /):
/
Result: 2
```

### Input/Output Example 3:
```
Enter the first number:
5
Enter the second number:
0
Enter operation (+, -, *, /):
/
Error: Division by zero
```

---
## 🔍 Explanation:
### Input:

- The program prompts the user to enter two numbers and a mathematical operation. The input is taken from the console.

### Switch-Case Logic:

- The `switch` statement checks which operation the user inputted. Based on the operator entered (`+`, `-`, `*`, or `/`), the corresponding operation is performed on `num1` and `num2`.

### Edge Case - Division by Zero:

- The program checks if the operation is division (`/`) and whether the second number is zero. If so, it displays an error message indicating division by zero.

