# Factorial Program in C#

## 🧑‍💻 **Overview**

This program calculates the **factorial** of a given number using two different approaches: **Recursive** and **Iterative**.

The **factorial** of a non-negative integer `n` is the product of all positive integers less than or equal to `n`. It is denoted as `n!` and is calculated as:
- `n! = n * (n-1) * (n-2) * ... * 1`
- Special Case: `0! = 1`

For example:
- `5! = 5 * 4 * 3 * 2 * 1 = 120`
- `3! = 3 * 2 * 1 = 6`

---

## 💻 **Program Explanation**

1. **Recursive Approach**:
   - This function calculates the factorial by calling itself repeatedly, multiplying `n` by the factorial of `n-1` until `n` reaches 0 or 1.

2. **Iterative Approach**:
   - This method uses a loop to compute the factorial, making it more efficient and easier to follow for larger numbers.

3. **Main Method**:
   - The program prompts the user to enter a number.
   - It then computes and displays the factorial of the number using both the recursive and iterative methods.

---

## 🧑‍💻 **Code:**

```csharp
using System;

namespace FactorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            // Recursive approach
            Console.WriteLine($"Factorial (Recursive) of {num}: {FactorialRecursive(num)}");

            // Iterative approach
            Console.WriteLine($"Factorial (Iterative) of {num}: {FactorialIterative(num)}");
        }

        static int FactorialRecursive(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * FactorialRecursive(n - 1);
        }

        static int FactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
```

---
## 🚀 Example Run:
- **Input:**
```
Enter a number:
5
```

- **Output:**
```
Factorial (Recursive) of 5: 120
Factorial (Iterative) of 5: 120
```

- **Input:**
```
Enter a number:
3
```

- **Output:**
```
Factorial (Recursive) of 3: 6
Factorial (Iterative) of 3: 6
```

---
## 🔍 Recursive vs Iterative:
### Recursive:

- Elegant and intuitive, but can be less efficient for large values of n due to the overhead of function calls.

### Iterative:

- More efficient, especially for larger values of n, as it avoids the function call stack overhead.

