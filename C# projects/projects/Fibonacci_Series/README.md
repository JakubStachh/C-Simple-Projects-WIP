# Fibonacci Series in C#

## 🔢 **Overview**

This program calculates the Fibonacci number at a given position using two different approaches: **Recursive** and **Iterative**.

The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, usually starting with 0 and 1. The sequence looks like this: `0, 1, 1, 2, 3, 5, 8, 13, 21, ...`.

---

## 💻 **Program Explanation**

1. **Recursive Approach**:
   - This function computes the Fibonacci number by calling itself for the previous two Fibonacci numbers until it reaches the base case (`n <= 1`).
   
2. **Iterative Approach**:
   - This method uses a loop to calculate the Fibonacci number, making it more efficient than the recursive approach, especially for larger numbers.

3. **Main Method**:
   - The program prompts the user for the Fibonacci position (`n`).
   - It then computes and prints the Fibonacci number at the given position using both approaches.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Fibonacci number position:");
            int n = int.Parse(Console.ReadLine());
            
            // Recursive approach
            Console.WriteLine($"Fibonacci (Recursive) at position {n}: {FibonacciRecursive(n)}");

            // Iterative approach
            Console.WriteLine($"Fibonacci (Iterative) at position {n}: {FibonacciIterative(n)}");
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;
            
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
```

---
## 🚀 Example Run:
- **Input:**
```
Enter the Fibonacci number position:
5
```
- **Output:**
```
Fibonacci (Recursive) at position 5: 5
Fibonacci (Iterative) at position 5: 5
```

- **Input:**
```
Enter the Fibonacci number position:
8
```

- **Output:**
```
Fibonacci (Recursive) at position 8: 21
Fibonacci (Iterative) at position 8: 21
```

---

## ⚡ How It Works:
- The user is asked to input the position in the Fibonacci sequence (e.g., `n`).

- The program calculates the Fibonacci number at position `n` using both recursive and iterative approaches.

- It prints out the result for both methods for comparison.
